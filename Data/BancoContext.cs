using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Doador.Models;
using Microsoft.EntityFrameworkCore;
namespace Doador.Data
{
  public class BancoContext : DbContext
  {
    public BancoContext(DbContextOptions<BancoContext> options) : base(options)
    {
    }

    public DbSet<DoadorModel> Doador {get; set;}

  }
}