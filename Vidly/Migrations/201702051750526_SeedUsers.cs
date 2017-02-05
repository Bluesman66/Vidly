namespace Vidly.Migrations
{
	using System;
	using System.Data.Entity.Migrations;
	
	public partial class SeedUsers : DbMigration
	{
		public override void Up()
		{
			Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8886d861-bd68-42a9-8314-2222ef16d9f2', N'guest@vidly.com', 0, N'AMwUJhQK6j9jASz4b+XLNzyO8u9sgIeTsDE6+BoDN+SLzouMK6K48ZuhkCj0OkYV9Q==', N'a83af915-edd6-49e2-ab77-a057f40c7978', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')");
			Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bc47b3ea-df12-48bc-b507-0b916a74c68d', N'admin@vidly.com', 0, N'AFSXgsVvtvL+qzu/ONd5IDDUiuo1A2LHLF+iGUhikTaskA1QKwVYH0NAIQ0oCCTMlw==', N'094b7638-dafa-4f33-b12f-61623321333d', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')");
			Sql("INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fac8c2de-d09b-40ba-9243-0ee2cf9a122c', N'CanManageMovies')");
			Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bc47b3ea-df12-48bc-b507-0b916a74c68d', N'fac8c2de-d09b-40ba-9243-0ee2cf9a122c')");
		}
		
		public override void Down()
		{
		}
	}
}
