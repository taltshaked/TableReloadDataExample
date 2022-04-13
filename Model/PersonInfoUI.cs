namespace AntDesignExample.Model
{
    public class PersonInfoUI : PersonInfo
    {
        public PersonInfoUI(PersonInfo personInfo)
        {
            Age = personInfo.Age;
            Company = personInfo.Company;
            Name = personInfo.Name;
        }

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
    }
}
