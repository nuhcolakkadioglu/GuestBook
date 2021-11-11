using GuestBook.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBook.DataAccess.Concrete.Mappings
{
    public class GuestBookMap : IEntityTypeConfiguration<GuestPost>
    {
        public void Configure(EntityTypeBuilder<GuestPost> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(25).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(25);
            builder.Property(x => x.Email).HasMaxLength(75);
            builder.Property(x => x.PostContent).HasMaxLength(500).IsRequired();

            builder.ToTable("GuestPosts");
        }
    }
}
