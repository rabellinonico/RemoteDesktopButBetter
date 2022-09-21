using RemoteDesktopButBetter.Helpers;
using RemoteDesktopButBetter.Models;
using System.Text.RegularExpressions;

namespace RemoteDesktopButBetter
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(GlobalClass.AppDataFilePath))
            {
                GlobalClass.SalvaAziende();
            }
            else
            {
                GlobalClass.LeggiAziende();
                AggiornaComboBoxGroup();
            }

            ComboBoxGroups.DataSource = GlobalClass.Aziende;

            if (ComboBoxGroups.SelectedIndex != -1)
            {
                ComboBoxGroups.Enabled = true;
                ButtonRemoveGroup.Enabled = true;
                AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);

                if (ComboBoxServers.Items.Count != 0)
                {
                    ButtonRemoveServer.Enabled = true;
                }
            }
        }

        // GROUPS
        private void ComboBoxGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGroups.SelectedIndex != -1)
            {
                ButtonEditGroup.Enabled = true;
                ButtonReorderGroups.Enabled = true;
                ButtonRemoveGroup.Enabled = true;

                ButtonAddServer.Enabled = true;

                AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);
                if (ComboBoxServers.Items.Count == 0)
                {
                    ComboBoxServers.Enabled = false;

                    ButtonEditServer.Enabled = false;
                    ButtonReorderServers.Enabled = false;
                    ButtonRemoveServer.Enabled = false;
                }
                else
                {
                    ComboBoxServers.SelectedIndex = 0;
                    ComboBoxServers.Enabled = true;

                    ButtonEditServer.Enabled = true;
                    ButtonReorderServers.Enabled = true;
                    ButtonRemoveServer.Enabled = true;
                }
            }
        }
        private void AggiornaComboBoxGroup()
        {
            if (GlobalClass.Aziende.Count == 0)
            {
                ComboBoxGroups.Enabled = false;
            }
            else
            {
                ComboBoxGroups.Enabled = true;
            }

            ComboBoxGroups.DataSource = null;
            ComboBoxGroups.DataSource = GlobalClass.Aziende;
            ComboBoxGroups.DisplayMember = "Name";
        }
        private void ButtonAddGroup_Click(object sender, EventArgs e)
        {
            string NomeAzienda = Prompt.ShowDialogOneInput("Group name:", "Add group");
            if (NomeAzienda != null && NomeAzienda.Trim() != "")
            {
                ServersGroup a = new()
                {
                    Name = NomeAzienda.Trim(),
                    Servers = new List<Server>()
                };
                GlobalClass.AddAzienda(a);

                AggiornaComboBoxGroup();

                ComboBoxGroups.SelectedIndex = ComboBoxGroups.Items.Count - 1;
            }
        }
        private void ButtonRemoveGroup_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Eliminare la Società/Azienda?", "Eliminazione Società/Azienda", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (ComboBoxGroups.SelectedIndex != -1)
                {
                    GlobalClass.RemoveAzienda((ServersGroup)ComboBoxGroups.SelectedItem);
                    AggiornaComboBoxGroup();

                    if (ComboBoxGroups.Items.Count > 0)
                    {
                        ComboBoxGroups.SelectedIndex = ComboBoxGroups.Items.Count - 1;
                        ComboBoxServers.SelectedIndex = -1;
                        AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);
                    }
                    else
                    {
                        ButtonEditGroup.Enabled = false;
                        ButtonReorderGroups.Enabled = false;
                        ButtonRemoveGroup.Enabled = false;

                        ComboBoxServers.Enabled = false;
                        ButtonAddServer.Enabled = false;
                        ButtonRemoveServer.Enabled = false;

                        ComboBoxGroups.SelectedIndex = -1;
                        ComboBoxServers.SelectedIndex = -1;
                    }
                }
            }
        }

        // SERVERS
        private void ComboBoxServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxGroups.SelectedIndex != -1 && ComboBoxServers.SelectedIndex != -1)
            {
                ButtonAvvioRemoteDesktop.Enabled = true;
            }
            else
            {
                ButtonAvvioRemoteDesktop.Enabled = false;
            }
        }
        private void AggiornaComboBoxServer(ServersGroup a)
        {
            ComboBoxServers.DataSource = null;
            ComboBoxServers.DataSource = GlobalClass.Aziende.FirstOrDefault(azienda => azienda.Name == a.Name)?.Servers.OrderBy(x => x.Index).ToList();
            ComboBoxServers.DisplayMember = "Fullname";
        }
        private void ButtonAddServer_Click(object sender, EventArgs e)
        {
            string[]? server = Prompt.ShowDialogTwoInput("Add Server", "Server name:", "IP Address:");
            if (server != null && server.Length == 2 && server[0].Trim() != "" && server[1].Trim() != "")
            {
                if (!IsValidIP(server[1].Trim()))
                {
                    MessageBox.Show("IP Address not valid.");
                    return;
                }

                Server s = new()
                {
                    Name = server[0].Trim(),
                    IPAddress = server[1].Trim(),
                    Fullname = server[0].Trim() + (server[0].Trim() != "" ? " | " : "") + server[1].Trim()
                };
                GlobalClass.AddServer((ServersGroup)ComboBoxGroups.SelectedItem, s);

                AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);

                if (ComboBoxServers.Items.Count != 0)
                {
                    ComboBoxServers.Enabled = true;
                    ComboBoxServers.SelectedIndex = ComboBoxServers.Items.Count - 1;

                    ButtonEditServer.Enabled = true;
                    ButtonReorderServers.Enabled = true;
                    ButtonRemoveServer.Enabled = true;
                }
            }
        }
        private void ButtonRemoveServer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Eliminare il Server?", "Eliminazione Server", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (ComboBoxServers.SelectedIndex != -1)
                {
                    GlobalClass.RemoveServer((ServersGroup)ComboBoxGroups.SelectedItem, (Server)ComboBoxServers.SelectedItem);
                    AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);

                    if (ComboBoxServers.Items.Count > 0)
                    {
                        ComboBoxServers.SelectedIndex = ComboBoxServers.Items.Count - 1;
                        ComboBoxServers.Enabled = true;

                        ButtonRemoveServer.Enabled = true;
                        ButtonEditServer.Enabled = true;
                        ButtonReorderServers.Enabled = true;
                    }
                    else
                    {
                        ComboBoxServers.SelectedIndex = -1;
                        ComboBoxServers.Enabled = false;

                        ButtonRemoveServer.Enabled = false;
                        ButtonEditServer.Enabled = false;
                        ButtonReorderServers.Enabled = false;
                    }
                }
            }
        }

        private void ButtonAvvioRemoteDesktop_Click(object sender, EventArgs e)
        {
            if (ComboBoxServers.SelectedIndex != -1)
            {
                Server server = (Server)ComboBoxServers.SelectedItem;
                string filename = Path.Combine(@"C:\Windows\system32\mstsc.exe");
                System.Diagnostics.Process.Start(filename, "/v:" + server.IPAddress + " /f");
            }
        }

        public static bool IsValidIP(string addr)
        {
            Regex check = new("^(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            return addr != "" && check.IsMatch(addr, 0);
        }

        private void ButtonEditGroup_Click(object sender, EventArgs e)
        {
            ServersGroup a = (ServersGroup)ComboBoxGroups.SelectedItem;
            string NomeGroup = Prompt.ShowDialogOneInput("Group name:", "Modify group", a.Name);
            if (NomeGroup != null && NomeGroup.Trim() != "")
            {
                GlobalClass.RemoveAzienda(a);
                a.Name = NomeGroup;
                GlobalClass.AddAzienda(a);

                AggiornaComboBoxGroup();

                ComboBoxGroups.SelectedIndex = ComboBoxGroups.Items.Count - 1;
            }
        }
        private void ButtonEditServer_Click(object sender, EventArgs e)
        {
            Server s = (Server)ComboBoxServers.SelectedItem;
            string[]? server = Prompt.ShowDialogTwoInput("Modify Server", "Server name:", "IP Address:", s.Name, s.IPAddress);
            if (server != null && server.Length == 2 && server[0].Trim() != "" && server[1].Trim() != "")
            {
                if (!IsValidIP(server[1].Trim()))
                {
                    MessageBox.Show("IP Address not valid.");
                    return;
                }

                GlobalClass.RemoveServer((ServersGroup)ComboBoxGroups.SelectedItem, s);
                s.Name = server[0].Trim();
                s.IPAddress = server[1].Trim();
                s.Fullname = server[0].Trim() + (server[0].Trim() != "" ? " | " : "") + server[1].Trim();
                GlobalClass.AddServer((ServersGroup)ComboBoxGroups.SelectedItem, s);

                AggiornaComboBoxServer((ServersGroup)ComboBoxGroups.SelectedItem);
            }
        }

        private void ButtonReorderGroups_Click(object sender, EventArgs e)
        {
            ReorderListComponent reorderListForm = new(ComboBoxGroups.Items.Cast<ServersGroup>().ToArray(), "Name");
            DialogResult result = reorderListForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                ServersGroup[] Items = reorderListForm.Items.Cast<ServersGroup>().ToArray();

                for (int i = 0; i < Items.Length; i++)
                {
                    Items[i].Index = i + 1;
                }

                GlobalClass.Aziende = Items.OrderBy(x => x.Index).ToList();
                GlobalClass.SalvaAziende();
                AggiornaComboBoxGroup();
            }
        }

        private void ButtonReorderServers_Click(object sender, EventArgs e)
        {
            ServersGroup g = (ServersGroup)ComboBoxGroups.SelectedItem;
            ReorderListComponent reorderListForm = new(ComboBoxServers.Items.Cast<Server>().ToArray(), "Fullname");
            DialogResult result = reorderListForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Server[] Items = reorderListForm.Items.Cast<Server>().ToArray();

                for (int i = 0; i < Items.Length; i++)
                {
                    Items[i].Index = i + 1;
                }

                GlobalClass.RemoveAzienda(g);
                g.Servers = Items.OrderBy(x => x.Index).ToList();
                GlobalClass.AddAzienda(g);
                GlobalClass.SalvaAziende();
                AggiornaComboBoxServer(g);
            }
        }
    }
}
