using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStoreAPI.Models
{
    public class MusicStoreModel : DbContext
    {
        // constructor
        public MusicStoreModel(DbContextOptions<MusicStoreModel> options) : base(options)
        {

        }
    }
}
