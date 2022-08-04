namespace UserControl.Models
{
    public interface IUsers
    {
        public bool LockUser(string email, DateTime? endDate);
        public bool UnlockUser(string email);
    }
}
