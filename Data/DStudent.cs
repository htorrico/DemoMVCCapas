using Entity;

namespace Data
{
    public class DStudent
    {
        public List<Student> Get()
        {

            //ADO .NET
            //Procedimiento Almacenado
            var result = new List<Student>();
            result.Add(new Student { StudentId=1, StudentName="Hugo", Age=35 });
            result.Add(new Student { StudentId =2, StudentName = "Juan", Age = 35 });

            return result;

        }
    }
}