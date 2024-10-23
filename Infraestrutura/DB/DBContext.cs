using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace minmal_api.Infraestrutura.DB
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DbContext> options) : base(options){
            
        }
    }
}