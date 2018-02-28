using System.Linq;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Hobbie[] hobbies = { new Hobbie(1, "Walking"), new Hobbie(2, "Swimming"), new Hobbie(3, "Bodybuilding") };

            var hoobie = hobbies.Where(h => h.Name.Equals("Walking"));
            var hoobieName = hobbies.Where(h => h.Name.Equals("Walking")).Select(h => h.Name);
            var anotherHobbie = from h in hobbies where h.Name.Equals("Walking") select h.Name ;
            var allHoobiesWithIdGreaterThenOne = hobbies.Where(h => h.Id > 1);

            var everyHobbieExceptFirstOne = hobbies.Skip(1);
            var swimmingHobbie = hobbies.Skip(1).Take(1);
        }
    }

    class Hobbie
    {
        public Hobbie(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
