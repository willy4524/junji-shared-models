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
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<StaffRole> StaffRoles { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyContact> CompanyContacts { get; set; }
        public DbSet<CompanyDelivery> CompanyDeliveries { get; set; }
        public DbSet<Inquiry> Inquiries { get; set; }
        public DbSet<InquiryDetail> InquiryDetails { get; set; }       
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }     

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

            modelBuilder.Entity<Shipment>()
                .Property(s => s.TotalAmount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShipmentProduct>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<ShipmentCode>()
                .HasIndex(c => c.Code16)
                .IsUnique();

            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionId });

            modelBuilder.Entity<StaffRole>()
                .HasKey(sr => new { sr.StaffId, sr.RoleId });

            modelBuilder.Entity<MemberLevel>().HasData(
                new MemberLevel { Id = 1, Name = "一般會員", Description = "可參加活動、集點兌換。", UpgradePoints = 0 },
                new MemberLevel { Id = 2, Name = "銀牌會員", Description = "集滿1000點，集點商品享9.9折。", UpgradePoints = 1000 },
                new MemberLevel { Id = 3, Name = "金牌會員", Description = "集滿3000點，集點商品享9.7折。", UpgradePoints = 3000 },
                new MemberLevel { Id = 4, Name = "白金會員", Description = "集滿5000點，集點商品享9.5折。", UpgradePoints = 5000 },
                new MemberLevel { Id = 5, Name = "鑽石會員", Description = "集滿10000點，集點商品享9.3折。", UpgradePoints = 10000 },
                new MemberLevel { Id = 6, Name = "至尊會員", Description = "集滿50000點，集點商品享9折。", UpgradePoints = 50000 }
            );

            // 權限
            modelBuilder.Entity<Permission>().HasData(
                new Permission { Id = 1, Code = "System.FullAccess", Name = "全系統權限", Desc = "超級管理員專用" }
                // 之後可繼續加 Product.Create, Product.Read ... 等
            );

            // 角色
            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, Name = "超級管理員", Desc = "所有功能", IsSystem = true }
            );

            // 角色對權限
            modelBuilder.Entity<RolePermission>().HasData(
                new RolePermission { RoleId = 1, PermissionId = 1 }
            );

            // 管理員帳號
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = 1,
                    StaffNo = "A001",
                    Name = "超級管理員",
                    Account = "admin",
                    PasswordHash = "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", // admin
                    Department = "管理部",
                    Position = "系統管理員",
                    IsActive = true,
                    CreatedAt = new DateTime(2024, 6, 16, 12, 0, 0)
                }
            );

            // 帳號指派超級管理員角色
            modelBuilder.Entity<StaffRole>().HasData(
                new StaffRole { StaffId = 1, RoleId = 1 }
            );

                        modelBuilder.Entity<CompanyContact>()
                .HasOne(c => c.Company)
                .WithMany(c => c.Contacts)
                .HasForeignKey(c => c.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CompanyDelivery>()
                .HasOne(d => d.Company)
                .WithMany(c => c.Deliveries)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            // 建議加索引、限制
            modelBuilder.Entity<Company>()
                .HasIndex(x => x.TaxId);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(p => p.Name)
                    .IsRequired()
                    .HasMaxLength(120);

                entity.Property(p => p.Code)
                    .HasMaxLength(50);

                entity.Property(p => p.Spec)
                    .HasMaxLength(80);

                entity.Property(p => p.Unit)
                    .HasMaxLength(16);

                entity.Property(p => p.Status)
                    .HasMaxLength(10)
                    .IsRequired();

                entity.Property(p => p.Cost)
                    .HasColumnType("decimal(18,2)");

                entity.Property(p => p.Price)
                    .HasColumnType("decimal(18,2)");

                entity.HasOne(p => p.Category)
                    .WithMany(c => c.Products)
                    .HasForeignKey(p => p.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict); // 保護分類被刪時商品還在
            });
            modelBuilder.Entity<Inquiry>()
                .HasMany(x => x.Details)
                .WithOne(d => d.Inquiry)
                .HasForeignKey(d => d.InquiryId);

            modelBuilder.Entity<InquiryDetail>()
                .HasOne(d => d.Product)
                .WithMany()
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Inquiry>()
                .HasOne(x => x.Company)
                .WithMany()
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PurchaseOrder>()
                .HasMany(p => p.Details)
                .WithOne(d => d.PurchaseOrder)
                .HasForeignKey(d => d.PurchaseOrderId);

            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(p => p.Company)
                .WithMany()
                .HasForeignKey(p => p.CompanyId);

            modelBuilder.Entity<PurchaseOrderDetail>()
                .HasOne(d => d.Product)
                .WithMany()
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            
            // 其他 Fluent API 設定可視需要補充
        }
    }

}
