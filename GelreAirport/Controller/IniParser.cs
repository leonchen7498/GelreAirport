using System;
using IniParser;
using IniParser.Model;
using System.IO;

namespace GelreAirport.Controller
{
    class IniParser
    {
        private readonly FileIniDataParser _parser = new FileIniDataParser();
        private readonly IniData _data;
        private readonly String _fileName = null;

        public IniParser(String file)
        {
            if (!File.Exists(file))
            {
                File.Create(file).Dispose();
            }
            this._fileName = file;
            this._data = this._parser.ReadFile(file);
        }

        public String GetValue(String section, String key)
        {
            return this._data[section][key];
        }

        public void SetValue(String section, String key, String value)
        {
            if (this._fileName != null)
            {
                this._data[section][key] = value;
                this._parser.WriteFile(this._fileName, this._data);
            }
        }
    }
}
