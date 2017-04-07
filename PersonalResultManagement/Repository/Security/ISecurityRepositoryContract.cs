namespace PersonalResultManagement.Repository.Security
{
    using Data.Model;

    interface ISecurityRepositoryContract
    {
        bool Save(Security security);
        bool Update(Security security);
        Security GetStudentSecurity(int StudentId);
    }
}
