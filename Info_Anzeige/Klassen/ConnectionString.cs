using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace Info_Anzeige.Klassen
{
    public class ConnectionString:INotifyPropertyChanged
    {
        private const string filepath = @"C:\ProgramData\AnzeigeInfo\data\connectionstring.ini";

        public event PropertyChangedEventHandler PropertyChanged;

        private string _datenbankname;
        public string DatenbankName
        {
            get { return this._datenbankname; }
            set
            {
                if (value != null)
                {
                    this._datenbankname = value;
                    OnPropertyChanged(nameof(DatenbankName));
                }
            }
        }

        private string _IpAdresse;
        public string IpAdresse
        {
            get { return this._IpAdresse; }
            set
            {
                if (value != null)
                {
                    this._IpAdresse = value;
                    OnPropertyChanged(nameof(IpAdresse));
                }
            }
        }

        private string _Port;
        public string Port
        {
            get { return this._Port; }
            set
            {
                if (value != null)
                {
                    this._Port = value;
                    OnPropertyChanged(nameof(Port));
                }
            }
        }

        private string? _LoginName;
        public string? LoginName
        {
            get { return this._LoginName; }
            set
            {
                if (value != null)
                {
                    this._LoginName = value;
                    OnPropertyChanged(nameof(LoginName));
                }
            }
        }

        private string? _Passwort;
        public string? Passwort
        {
            get { return this._Passwort; }
            set
            {
                if (value != null)
                {
                    this._Passwort = value;
                    OnPropertyChanged(nameof(Passwort));
                }
            }
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string CreateConnectionString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(
                "Server={0};" +
                "Port={1};" +
                "Database={2};" +
                "IntegratedSecurity=true;", _datenbankname, _IpAdresse, Port);

            return sb.ToString();
        }

        public void SafeConnectionString()
        {
            if((_datenbankname != "" && _datenbankname != null) && (_IpAdresse != "" && _IpAdresse != null) && (_Port != "" && _Port != null))
            {
                try
                {
                    string directoryPath = System.IO.Path.GetDirectoryName(filepath);

                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    // Create the file, or overwrite if the file exists.
                    using (FileStream file = File.Create(filepath))
                    {
                        byte[] info = new UTF8Encoding(true).GetBytes(CreateConnectionString());
                        // Add some information to the file.
                        file.Write(info);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ein Wert wurde nicht korrekt angegeben");
            }
        }
    

        public string? LoadConnectionString()
        {
            try
            {
                // Open the stream and read it back.
                using (StreamReader readfile = File.OpenText(filepath))
                {
                    string linevalue;
                    StringBuilder sb = new StringBuilder(); 
                    
                    while ((linevalue = readfile.ReadLine()) != null)
                    {                
                        sb.AppendLine(linevalue);
                    }

                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        
    }
}
