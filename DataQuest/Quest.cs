using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataQuest
{
    /// <summary>
    /// Quest Game Container
    /// That contain:
    ///     <see cref="Locations"/>,
    ///     <see cref="Roads"/>,
    ///     <see cref="Flags"/>,
    ///     <see cref="Groups"/>,
    ///     Start point
    /// </summary>
    [Serializable]
    public class Quest
    {
        public static string ProgramVersion = "Beta 0.1";
        public string Name { get; set; }
        
        public List<ILocation> Locations { get; set; }
        
        public List<IRoad> Roads { get; set; }
        
        public List<string> Flags { get; set; }

        public List<Group> Groups { get; set; }

        public ILocation Start { get; set; }

        /// <summary>
        /// Serializes quest to binary file
        /// </summary>
        /// <param name="path">Path to binary file</param>
        public void Dump(string path)
        {
            var binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream(path,
               FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, this);
            }
        }

        /// <summary>
        /// Deserializes Quest from binary file
        /// </summary>
        /// <param name="path">Path to binary file</param>
        /// <returns><see cref="Quest"/> object</returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="FormatException">Thrown when file is not Quest binary</exception>
        static public Quest Load(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException($"File {path} not found");
            var binFormat = new BinaryFormatter();
            
            using (var fStream = new FileStream(path,
               FileMode.Open, FileAccess.Read, FileShare.None))
            {
                var obj = binFormat.Deserialize(fStream);
                if (typeof (Quest) == obj.GetType())
                    return (Quest) obj;
                throw new FormatException($"Can`t deserialize {path} to Quest");
            }
        }

        /// <summary>
        /// Serializes quest to XML
        /// NotImpliemented
        /// </summary>
        /// <param name="path">Path to XML</param>
        public void DumpXml(string path)
        {
            throw new NotImplementedException($"Current version({ProgramVersion}) can`t do that");
        }

        /// <summary>
        /// Deserializes quest from XML
        /// NotImpliemented
        /// </summary>
        /// <returns><see cref="Quest"/> object</returns>
        /// <param name="path">Path to XML</param>
        public static Quest LoadXml(string path)
        {
            throw new NotImplementedException($"Current version({ProgramVersion}) can`t do that");
        }

        /// <summary>
        /// Async Serializes quest to binary file
        /// </summary>
        /// <param name="path">Path to binary file</param>
        public Task DumpAsync(string path)
        {
            return Task.Run(() => Dump(path));
        }

        /// <summary>
        /// Async Deserializes Quest from binary file
        /// </summary>
        /// <param name="path">Path to binary file</param>
        /// <returns>Quest object</returns>
        /// <exception cref="FileNotFoundException"></exception>
        /// <exception cref="FormatException">Thrown when file is not Quest binary</exception>
        static public Task<Quest> LoadAsync(string path)
        {
            return Task.Run(() => Load(path));
        }

        /// <summary>
        /// Async Serializes quest to XML
        /// NotImpliemented
        /// </summary>
        /// <param name="path">Path to XML</param>
        public Task DumpXmlAsync(string path)
        {
            return Task.Run(() => DumpXml(path));
        }


        /// <summary>
        /// Async Deserializes quest from XML
        /// NotImpliemented
        /// </summary>
        /// <param name="path">Path to XML</param>
        public static Task<Quest> LoadXmlAsync(string path)
        {
            return Task.Run(()=>LoadXml(path));
        }

    }
}
