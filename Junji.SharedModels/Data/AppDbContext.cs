using Microsoft.EntityFrameworkCore;
using Junji.SharedModels.Models; // ✅ 原本是 MemberBack.Models，改成你放 Models 的 namespace

namespace Junji.SharedModels.Data // ✅ 改成 shared 的命名空間
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<MemberLevel> MemberLevels { get; set; }
        public DbSet<ConsumptionHistory> ConsumptionHistories { get; set; }
        public DbSet<PointHistory> PointHistories { get; set; }
        public DbSet<InviteHistory> InviteHistories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Whiteboard> Whiteboards { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentProduct> ShipmentProducts { get; set; }
        public DbSet<ShipmentCode> ShipmentCodes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>()
                .HasOne(m => m.MemberLevel)
                .WithMany(l => l.Members)
                .HasForeignKey(m => m.MemberLevelId);

            modelBuilder.Entity<Member>()
                .HasOne(m => m.Referrer)
                .WithMany()
                .HasForeignKey(m => m.ReferrerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InviteHistory>()
                .HasOne(i => i.Referrer)
                .WithMany(m => m.InviteHistories)
                .HasForeignKey(i => i.ReferrerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<InviteHistory>()
                .HasOne(i => i.Invitee)
                .WithMany()
                .HasForeignKey(i => i.InviteeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ConsumptionHistory>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Whiteboard>()
                .HasIndex(w => w.Type)
                .IsUnique();
                
            modelBuilder.Entity<Shipment>()
                .HasMany(s => s.Products)
                .WithOne(p => p.Shipment)
                .HasForeignKey(p => p.ShipmentId);

            modelBuilder.Entity<Shipment>()
                .HasMany(s => s.Codes)
                .WithOne(c => c.Shipment)
                .HasForeignKey(c => c.ShipmentId);

            modelBuilder.Entity<ShipmentCode>()
                .HasIndex(c => c.Code16)
                .IsUnique();
            // 其他 Fluent API 設定可視需要補充
        }
    }

}
