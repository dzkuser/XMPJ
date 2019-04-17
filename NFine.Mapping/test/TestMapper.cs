using NFine.Domain._03_Entity.test;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Mapping.test
{
   public class TestMapper: EntityTypeConfiguration<DzkTest>
    {
        public TestMapper() {
            this.ToTable("dzktest");
            this.HasKey(t=>t.ID);
        }

    }
}
