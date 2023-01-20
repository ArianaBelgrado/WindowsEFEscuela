namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class two : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Alumnoes", newName: "Alumno");
            RenameTable(name: "dbo.Profesors", newName: "Profesor");
            AddColumn("dbo.Alumno", "Profesor_ProfesorId", c => c.Int());
            AlterColumn("dbo.Alumno", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Alumno", "FechaNacimiento", c => c.DateTime());
            AlterColumn("dbo.Profesor", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Profesor", "Apellido", c => c.String(nullable: false, maxLength: 50, unicode: false));
            CreateIndex("dbo.Alumno", "Profesor_ProfesorId");
            AddForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Profesor", "ProfesorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "Profesor_ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "Profesor_ProfesorId" });
            AlterColumn("dbo.Profesor", "Apellido", c => c.String());
            AlterColumn("dbo.Profesor", "Nombre", c => c.String());
            AlterColumn("dbo.Alumno", "FechaNacimiento", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Alumno", "Apellido", c => c.String());
            AlterColumn("dbo.Alumno", "Name", c => c.String());
            DropColumn("dbo.Alumno", "Profesor_ProfesorId");
            RenameTable(name: "dbo.Profesor", newName: "Profesors");
            RenameTable(name: "dbo.Alumno", newName: "Alumnoes");
        }
    }
}
