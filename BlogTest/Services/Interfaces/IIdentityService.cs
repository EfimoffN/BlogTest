using Models;
using System.Threading.Tasks;

namespace BlogTest.Services.Interfaces
{
	public interface IIdentityService
    {
		Task<User> GetUser(string userName);
	}
}
