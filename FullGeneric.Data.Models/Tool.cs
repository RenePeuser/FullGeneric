namespace FullGeneric.Data.Models
{
    public class Tool
    {

        public Tool()
        {

        }

        public Tool(string id)
        {
            ID = id;
        }

        public Tool(string id, string name)
        {
            
        }


        public string ID { get; set; }

        public string Name { get; set; }
    }
}
