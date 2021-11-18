using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PimViii.Models;

namespace PimViii.Data
{
    public class PimViiiContext : DbContext
    {
        public PimViiiContext (DbContextOptions<PimViiiContext> options)
            : base(options)
        {
        }

        public DbSet<PimViii.Models.Pessoa> Pessoa { get; set; }

        public DbSet<PimViii.Models.Endereco> Endereco { get; set; }

        public DbSet<PimViii.Models.Telefone> Telefone { get; set; }

        public DbSet<PimViii.Models.TipoTelefone> TipoTelefone { get; set; }
    }
}
