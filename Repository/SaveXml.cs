﻿using System;
using System.IO;
using System.Xml.Serialization;

namespace Repository
{
    public class SaveXml : ISaveable
    {
        public void Save(LogDto logDto)
        {
            var xmlSerializer = new XmlSerializer(typeof(LogDto));
            // TODO
            // read path and filename from appconfig
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/log.xml";
            var file = File.Create(path);
            xmlSerializer.Serialize(file, logDto);
            file.Close();
        }
    }
}
