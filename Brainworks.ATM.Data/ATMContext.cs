using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brainworks.ATM.Data
{
    public class ATMContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = @"Data Source=DESKTOP-MHQ1JL8\SQLEXPRESS; Initial catalog=BAM; Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
