namespace FirstSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        CourseID = c.Int(nullable: false, identity: true),
                        KategoriaId = c.Int(nullable: false),
                        TitleCourse = c.String(),
                        AuthorCourse = c.String(),
                        AddingDate = c.DateTime(nullable: false),
                        FileName = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Bestseller = c.Boolean(nullable: false),
                        Hidden = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseID)
                .ForeignKey("dbo.Kategoria", t => t.KategoriaId, cascadeDelete: true)
                .Index(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        KategoriaName = c.String(),
                        KategoriaDescription = c.String(),
                        IconName = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.OrderPosition",
                c => new
                    {
                        OrderPositionId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        order_OrdersId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderPositionId)
                .ForeignKey("dbo.Course", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.order_OrdersId)
                .Index(t => t.CourseId)
                .Index(t => t.order_OrdersId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrdersId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Street = c.String(),
                        Town = c.String(),
                        PostCode = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Comment = c.String(),
                        AddingDate = c.DateTime(nullable: false),
                        OrderStates = c.Int(nullable: false),
                        Value = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrdersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPosition", "order_OrdersId", "dbo.Order");
            DropForeignKey("dbo.OrderPosition", "CourseId", "dbo.Course");
            DropForeignKey("dbo.Course", "KategoriaId", "dbo.Kategoria");
            DropIndex("dbo.OrderPosition", new[] { "order_OrdersId" });
            DropIndex("dbo.OrderPosition", new[] { "CourseId" });
            DropIndex("dbo.Course", new[] { "KategoriaId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderPosition");
            DropTable("dbo.Kategoria");
            DropTable("dbo.Course");
        }
    }
}
