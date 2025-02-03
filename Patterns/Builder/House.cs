
namespace DiveIntoDesignPatterns.Patterns.Builder
{
    public class House
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;
            foreach (object part in this._parts)
            {
                str += part + ", ";
            }
            str = str.Remove(str.Length - 2);

            return "La casa tiene : " + str;
        }
    }
}
