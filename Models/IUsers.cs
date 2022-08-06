namespace UserControl.Models
{
    public interface IUsers
    {
        public bool LockUser(string email, DateTime? endDate, string currentUser);
        public bool UnlockUser(string email);
    }
}
