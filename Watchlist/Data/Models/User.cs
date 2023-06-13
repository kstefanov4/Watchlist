using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Watchlist.Data.Models
{
    [Comment("The user of the Watchlist")]
    public class User : IdentityUser
    {
        public IEnumerable<UserMovie> UsersMovies { get; set; } = new List<UserMovie>();
    }
}
