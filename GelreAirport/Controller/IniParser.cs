using System;
using IniParser;
using IniParser.Model;
using System.IO;

namespace GelreAirport.Controller
{
    internal class IniParser
    {
        private readonly FileIniDataParser _parser = new FileIniDataParser();
        private readonly IniData _data;
        private readonly string _fileName = null;

        public IniParser(string file)
        {
            if (!File.Exists(file))
            {
                File.Create(file).Dispose();
            }
            this._fileName = file;
            this._data = this._parser.ReadFile(file);
        }

        public string GetValue(string section, string key)
        {
            return this._data[section][key];
        }

        public void SetValue(string section, string key, string value)
        {
            if (this._fileName == null) return;
            this._data[section][key] = value;
            this._parser.WriteFile(this._fileName, this._data);
        }
    }
}
