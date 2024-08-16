namespace WebAPI.Models
{
    public interface ILogin
    {
        bool ValidateUser(string uname,string pwd);
    }
    public class LoginRepo : ILogin
    {
        NorthwindContext context;
        public LoginRepo(NorthwindContext _context)
        {
            context = _context;     
        }
        public bool ValidateUser(string uname,string pwd)
        {
            User user=context.Users.Find(uname);
            if (user.Password == pwd)
            {
                return true;    
            }
            else
            {
                return  false;  
            }
            
        }
    }
}
