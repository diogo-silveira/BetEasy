using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace dotnet_code_challenge.Json
{
    public class Deserialize
    {
        public static T LoadJson<T>(string filename) where T : class, new()
        {
            if (!File.Exists(filename))
                return new T();

            TextReader fileStream = null;
            try
            {
                fileStream = new StreamReader(filename);

                JsonSerializer se = new JsonSerializer();

                JsonTextReader reader = new JsonTextReader(fileStream);

                return se.Deserialize<T>(reader);
            }
            catch (Exception ex)
            {
                return new T();
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
            }
        }

    }
}
