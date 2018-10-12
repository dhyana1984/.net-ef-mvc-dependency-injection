using EF.Core.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.Data.Mapping
{
    public class UserProfileMap: EntityTypeConfiguration<UserProfile>
    {
        public UserProfileMap()
        {
            ToTable("UserProfiles");

            HasKey(t => t.ID);

            Property(t => t.FirstName).IsRequired();
            Property(t => t.LastName).IsRequired();
            Property(t => t.Address);
            Property(t => t.CreateTime).IsRequired();
            Property(t => t.ModifyTime).IsRequired();
            Property(t => t.IP);

            HasRequired(t => t.User).WithRequiredDependent(t => t.UserProfile);

               
        }
    }
}
