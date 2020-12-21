using System.Globalization;
using System.Windows;
using ErikEJ.SqlCeToolbox.Helpers;
using ReverseEngineer20;

namespace EFCorePowerTools.Dialogs
{
    public partial class ConnectionDialog 
    {
        private bool _createDb;
        private string _connectionString;
        private string _filter;

        public ConnectionDialog()
        {
            Telemetry.TrackPageView(nameof(ConnectionDialog));
            InitializeComponent();
            Background = VsThemes.GetWindowBackground();
            SaveButton.IsEnabled = false;
        }

        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
        }

        public DatabaseType DbType { get; set; }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void txtConnection_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConnection.Text)) return;
            _connectionString = txtConnection.Text;
            SaveButton.IsEnabled = true;
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmdDatabaseType.SelectedValue != null)
            {
                DbType = (DatabaseType)int.Parse(cmdDatabaseType.SelectedValue.ToString(), CultureInfo.InvariantCulture);
            }
        }
    }
}