using System.Security.Claims;

namespace JwtWebApiTutorial.Service.UserService
{

    public class UserService : IUserService
    {
        private IHttpContextAccessor _HttpContextAccessor;

        public UserService(IHttpContextAccessor httpContextAccessor)
        {
            _HttpContextAccessor = httpContextAccessor;
        }

        public string GetMyName()
        {
            var result = string.Empty;
            if (_HttpContextAccessor.HttpContext != null)
            {
                result = _HttpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name); 
            }
            return result;
        }
    }
}
