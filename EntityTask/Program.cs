using EntityTask.Controllers;

namespace EntityTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
           GroupController groupController = new GroupController();
            groupController.AddGroup();
            StudentController studentController = new StudentController();  
            studentController.AddStudent();
            studentController.AddStudent();
            studentController.UpdateStudent();
            studentController.DeleteStudent();
            groupController.DeleteGroup();
        }
    }
}
