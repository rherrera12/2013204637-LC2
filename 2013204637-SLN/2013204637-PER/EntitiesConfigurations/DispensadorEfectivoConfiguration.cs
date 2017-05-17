﻿using _2013204637;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013204637_PER.EntitiesConfigurations
{
    public class DispensadorEfectivoConfiguration : EntityTypeConfiguration<DispensadorEfectivo>
    {
        public DispensadorEfectivoConfiguration()
        {
            HasKey(a => a.DispensadorEfectivoId);
            Property(v => v.DispensadorEfectivoId)
                .IsRequired();
            Property(v => v.Contador)
                .IsRequired();
        }
    }
}
