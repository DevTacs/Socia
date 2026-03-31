using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Data;

namespace src.Repositories
{
    public abstract class BaseRepository(SociaDbContext context)
    {
        protected readonly SociaDbContext _context = context;
    }
}