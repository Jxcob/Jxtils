using System.Linq;
using System.Diagnostics;

namespace Jxtils.Managers
{
    /// <summary>
    /// Similar to the titled data converter, but for data repeated without names, and for intergers only.
    /// </summary>
    public class IteratedDataManager
    {
        /// <summary>
        /// Where all the data is stored, as ints only.
        /// </summary>
        public int[] Values { get; set; }

        /// <summary>
        /// Sets the already existing data array to be equal to the provided array.
        /// </summary>
        /// <param name="deserializedData">The already deserialized data.</param>
        public IteratedDataManager(int[] deserializedData)
        {
            Values = deserializedData;
        }

        /// <summary>
        /// Deserializes all the data into the int array.
        /// </summary>
        /// <param name="serializedData">The data to be deserialized.</param>
        public IteratedDataManager(string serializedData)
        {
            string[] values = serializedData.Split('|');

            Values = new int[values.Count()];

            for (int i = 0; i < values.Count(); i++)
            {
                Values[i] = int.Parse(values[i]);
            }
        }

        /// <summary>
        /// Used for getting/setting data via the array.
        /// </summary>
        /// <param name="index">The index you want to access from the array.</param>
        /// <returns>The selected value from the array.</returns>
        public int this[int index]
        {
            get => Values[index];
            set => Values[index] = value;
        }

        /// <summary>
        /// Joins the array into a serialized string.
        /// </summary>
        /// <returns>The serialized string.</returns>
        public override string ToString()
        {
            return string.Join("|", Values);
        }
    }
}
