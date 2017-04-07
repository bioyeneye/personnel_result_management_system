namespace PersonalResultManagement.Repository.Student
{
    using Data.Model;
    interface IStudentRepositoryContract
    {
        bool Register(Student student);
        bool Login(Student student);
        bool ResetPassword(Student student);
        int GetStudentId(string matric);
        bool IsStudentMember(string matric, string password);
        bool UpdateStudent(int student, Student studentDetail);
    }
}
