namespace UserManagementApp.Models
{
    public interface IEdit
    {        
        string ValidateWithErrorMsg();
        void StartEdit();
        void ResetUserOld();
    }
}