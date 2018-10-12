using EF.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Mapping
{
    public class UserMap:EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("Users");

            HasKey(t => t.ID);

            Property(t => t.UserName).IsRequired();
            Property(t => t.Email).IsRequired();
            Property(t => t.Password).IsRequired();
            Property(t => t.CreateTime).IsRequired();
            Property(t => t.ModifyTime).IsRequired();
            Property(t => t.IP);
        }
    }
}
