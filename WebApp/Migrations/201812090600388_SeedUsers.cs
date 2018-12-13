namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'547b7990-a622-4fb3-a48d-09d0f602efca', N'guest@webapp.com', 0, N'ADCnRSaS+bSJpvCYsjLNxMuC6YWBCFbhF1sOn7XW3Gt3ePtrCvWSLkD/eiop5T/AiQ==', N'8f178dd7-47ab-421c-addd-75607b95dca8', NULL, 0, 0, NULL, 1, 0, N'guest@webapp.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cea963de-4c1c-4040-8d75-9d8787a980ce', N'admin@webapp.com', 0, N'AJ22Ez2MsMUL/JQHhaMXOFL2EE3J+rkqLGcnwjrEnsNGLnjpdtSYWsbbvppJoZpMFg==', N'6a9085c3-3d2e-4d5d-8192-18644f047ab8', NULL, 0, 0, NULL, 1, 0, N'admin@webapp.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'df462c32-ebd7-4f3b-b89c-0677e61f7829', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cea963de-4c1c-4040-8d75-9d8787a980ce', N'df462c32-ebd7-4f3b-b89c-0677e61f7829')
");
        }
        
        public override void Down()
        {
        }
    }
}
