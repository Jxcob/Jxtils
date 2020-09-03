using System.Collections.Generic;
using System.Text;

namespace Jxtils.Managers
{
    /// <summary>
    /// A specific style of data conversion, useful for less storage-use in SQL databases. This is stored in a dictionary format.
    /// </summary>
    public class LabelledDataManager
    {
        /// <summary>
        /// Where all the data is stored, as strings only.
        /// </summary>
        public Dictionary<string, int> Values { get; set; }

        /// <summary>
        /// Replaces the already existing dictionary for the one provided.
        /// </summary>
        /// <param name="deserializedData">The replacement dictionary.</param>
        public LabelledDataManager(Dictionary<string, int> deserializedData)
        {
            Values = deserializedData;
        }

        /// <summary>
        /// Converts all serialized data into a dictionary.
        /// </summary>
        /// <param name="serializedData">The data being deserialized.</param>
        public LabelledDataManager(string serializedData)
        {
            Values = new Dictionary<string, int>();
            {
                foreach (string singularData in serializedData.Split('|'))
                {
                    string[] values = singularData.Split(':');

                    Values.Add(values[0], int.Parse(values[1]));
                }
            }
        }

        /// <summary>
        /// Gets and sets data via the dictionary or array.
        /// </summary>
        /// <param name="key">The key for the value you are getting/setting.</param>
        /// <returns>The value from the dictionary.</returns>
        public int this[string key]
        {
            get => Values[key];
            set => Values[key] = value;
        }

        /// <summary>
        /// Converts the dictionary to a string.
        /// </summary>
        /// <returns>The dictionary, but serialized and in string form.</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (KeyValuePair<string, int> singularData in Values)
            {
                stringBuilder.Append(singularData.Key + ":" + singularData.Value + "|");
            }

            return stringBuilder.Remove(stringBuilder.Length - 1, 1).ToString();
        }
    }
}
