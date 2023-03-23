using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.DataAccess.Configurations
{
    public class AdvertisementUserConfiguration : IEntityTypeConfiguration<AdvertisementUser>
    {
        public void Configure(EntityTypeBuilder<AdvertisementUser> builder)
        {
            builder.HasIndex(x => new { x.AdvertisementId, x.AppUserId }).IsUnique();
            builder.Property(x => x.CvPath).HasMaxLength(500).IsRequired();
            builder.HasOne(x=>x.Advertisement).WithMany(x=>x.AdvertisementUsers).HasForeignKey(x=>x.AdvertisementId);
            builder.HasOne(x => x.AppUser).WithMany(x => x.AdvertisementUsers).HasForeignKey(x => x.AppUserId);
            builder.HasOne(x => x.AdvertisementUserStatus).WithMany(x => x.AdvertisementUsers)
                .HasForeignKey(x => x.AdvertisementUserStatusId);
            builder.HasOne(x => x.MilitaryStatus).WithMany(x => x.AdvertisementUsers)
                .HasForeignKey(x => x.MilitaryStatusId);


        }
    }
}