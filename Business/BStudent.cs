using Data;
using Entity;

namespace Business
{
    public class BStudent
    {
        public List<Student> Get()
        {
            DStudent data = new DStudent();
            return data.Get();
        }
    }
}