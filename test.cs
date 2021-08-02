
using System.Windows.Forms;

namespace CODFramework
{
    public class Test : IScript
    {
        private bool _enabled = true;
        private string _version = "1.0";
        string IScript.Name { get { return "TestScript"; } }

        string IScript.Description { get { return "this is a test"; } }

        string IScript.Version { get { return _version; } }

        bool IScript.WantButton { get { return true; } }

        bool IScript.Enabled { get { return _enabled; } set { _enabled = value; } }

        void IScript.Close()
        {
            MessageBox.Show("Will close now");
        }

        void IScript.Initialize()
        {
            MessageBox.Show("OTA Update received version: " + _version);
        }
        Panel IScript.GenerateUI() {
            var panel = new Panel();
            panel.BackColor = System.Drawing.Color.Red;
            panel.Dock = DockStyle.Fill;
            panel.Controls.Add(new Label { AutoSize = true,
            Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
            Location = new System.Drawing.Point(428, 211),
            Name = "label1",
            Size = new System.Drawing.Size(168, 29),
            TabIndex = 0,
            Text = "This is a test! Welcome to version " + _version 
            }) ;
            return panel;
        }

        void IScript.OnButtonPress()
        {
            MessageBox.Show("test");
        }
    }
}
