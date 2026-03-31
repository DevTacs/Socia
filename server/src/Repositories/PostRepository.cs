using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using src.Data;
using src.Repositories.Interfaces;

namespace src.Repositories
{
    public class PostRepository(SociaDbContext context) : BaseRepository(context), IPostRepository
    {

    }
}