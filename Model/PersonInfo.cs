namespace AntDesignExample.Model
{
    public class PersonInfo
    {
        public string Id
        {
            get
            {
                return $"{Name} - {Company}";
            }
            set
            {

            }
        }
        public string? Company { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
    }
}
