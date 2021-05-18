using System.Net.Http;
using System.Threading.Tasks;
using JRMDesktopUI.Library.Models;
using JRMDesktopUI.Models;

namespace JRMDesktopUI.Library.Api
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }
        Task<AuthenticatedUser> Authenticate(string username, string password);
        Task<LoggedInUserModel> GetLoggedUnserInfo(string token);
    }
}