using FullGeneric.Data.Models;

namespace FullGeneric.ViewModels
{
    public class PersonViewModel
    {

        private Person _person;
        public PersonViewModel(Person person)
        {
            _person = person;
        }
        
        public string name
        {
            get { return _person.Name; }
            set { _person.Name = value; }
        }
    }
}
