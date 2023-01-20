namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class three : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "Profesor_ProfesorId" });
            DropColumn("dbo.Alumno", "Profesor_ProfesorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Alumno", "Profesor_ProfesorId", c => c.Int());
            CreateIndex("dbo.Alumno", "Profesor_ProfesorId");
            AddForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Profesor", "ProfesorId");
        }
    }
}
