using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using restaurantApi.Models;

namespace restaurantApi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<plat>().HasData(new plat { id = 1, name = "Plat 1", prix = 10, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 2, name = "Plat 2", prix = 20, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 3, name = "Plat 3", prix = 30, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 4, name = "Plat 4", prix = 40, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 5, name = "Plat 5", prix = 50, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 6, name = "Plat 6", prix = 60, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 7, name = "Plat 7", prix = 70, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 8, name = "Plat 8", prix = 80, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 9, name = "Plat 9", prix = 90, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 10, name = "Plat 10", prix = 100, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 11, name = "Plat 11", prix = 110, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 12, name = "Plat 12", prix = 120, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 13, name = "Plat 13", prix = 130, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 14, name = "Plat 14", prix = 140, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 15, name = "Plat 15", prix = 150, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 16, name = "Plat 16", prix = 160, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 17, name = "Plat 17", prix = 170, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 18, name = "Plat 18", prix = 180, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 19, name = "Plat 19", prix = 190, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 20, name = "Plat 20", prix = 200, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" },
            new plat { id = 21, name = "Plat 21", prix = 210, images = "https://upload.wikimedia.org/wikipedia/commons/8/81/Chinese_Chawal_in_Basmati.jpg" },
            new plat { id = 22, name = "Plat 22", prix = 220, images = "https://s3-eu-west-1.amazonaws.com/images-ca-1-0-1-eu/tag_photos/original/2426/plat_principal_flickr_2304576748_f79c906b85_b.jpg" }
);
        }
        public DbSet<restaurantApi.Models.Reservation> Reservation { get; set; } = default!;
        public DbSet<restaurantApi.Models.plat> plat { get; set; } = default!;
    }
}