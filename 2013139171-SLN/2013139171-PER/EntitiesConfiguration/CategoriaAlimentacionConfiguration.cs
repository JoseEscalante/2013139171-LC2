﻿using _2013139171_ENT;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013139171_PER.EntitiesConfiguration
{
    class CategoriaAlimentacionConfiguration : EntityTypeConfiguration<CategoriaAlimentacion>
    {
        public CategoriaAlimentacionConfiguration()
        {
            ToTable("Alimentacion");
            Property(a => a.nombre).HasMaxLength(255);
        }
    }
}