using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoralTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace CoralTestTask.Data.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(CoralDbContext context) : base(context)
        {
        }
    }
}
