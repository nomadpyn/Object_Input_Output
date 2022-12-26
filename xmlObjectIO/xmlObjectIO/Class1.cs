using System.Xml.Serialization;
using System;
using System.ComponentModel;

namespace xmlObjectIO
{
    public static class xmlFileIO
    {
        public static void SaveList<T>(List<T> data, string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(List<T>));
            try
            {
                using (Stream fs = File.Create(path))
                {
                    xmlF.Serialize(fs, data);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static List<T> LoadList<T>(string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(List<T>));
            try
            {
                using(Stream fs = File.OpenRead(path))
                {
                    return (List<T>)xmlF.Deserialize(fs);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            return new List<T>();
        }
        public static void SaveBindingList<T>(BindingList<T> data, string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(BindingList<T>));
            try
            {
                using (Stream fs = File.Create(path))
                {
                    xmlF.Serialize(fs, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static BindingList<T> LoadBindingList<T>(string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(BindingList<T>));
            try
            {
                using (Stream fs = File.OpenRead(path))
                {
                    
                    return (BindingList<T>)xmlF.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return new BindingList<T>();
        }
        public static void SaveObj<T>(T data, string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(T));
            try
            {
                using (Stream fs = File.Create(path))
                {
                    xmlF.Serialize(fs, data);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static T LoadObj<T>(string path = "data.xml")
        {
            XmlSerializer xmlF = new XmlSerializer(typeof(T));
            try
            {
                using (Stream fs = File.OpenRead(path))
                {
                    return (T)xmlF.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return default(T);
        }
    }
}