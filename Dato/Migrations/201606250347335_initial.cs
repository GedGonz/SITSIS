namespace Dato.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        departamento = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                        Pais_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.Pais_Id)
                .Index(t => t.Pais_Id);
            
            CreateTable(
                "dbo.Municipios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        municipio = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                        Departamento_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departamentoes", t => t.Departamento_Id)
                .Index(t => t.Departamento_Id);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        primernombre = c.String(nullable: false, unicode: false),
                        segundonombre = c.String(unicode: false),
                        primerApellido = c.String(nullable: false, unicode: false),
                        segundoApellido = c.String(unicode: false),
                        edad = c.DateTime(nullable: false, precision: 0),
                        tiposanguineo = c.String(nullable: false, unicode: false),
                        foto = c.String(unicode: false),
                        cedula = c.String(unicode: false),
                        direccion = c.String(nullable: false, unicode: false),
                        estadocivil = c.String(nullable: false, unicode: false),
                        celular = c.Int(nullable: false),
                        telefono = c.Int(nullable: false),
                        genero = c.String(nullable: false, unicode: false),
                        estado = c.String(unicode: false),
                        fechacre = c.DateTime(nullable: false, precision: 0),
                        Municipio_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Municipios", t => t.Municipio_Id)
                .Index(t => t.Municipio_Id);
            
            CreateTable(
                "dbo.Docentes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NumSeguro = c.String(unicode: false),
                        Persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .Index(t => t.Persona_Id);
            
            CreateTable(
                "dbo.Docente_estudio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estudio = c.String(unicode: false),
                        Ano = c.Int(nullable: false),
                        Docente_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Docentes", t => t.Docente_Id)
                .Index(t => t.Docente_Id);
            
            CreateTable(
                "dbo.Estudiantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        carnet = c.String(nullable: false, unicode: false),
                        estado = c.Int(nullable: false),
                        Persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .Index(t => t.Persona_Id);
            
            CreateTable(
                "dbo.Estudiante_estudio",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estudio = c.String(nullable: false, unicode: false),
                        ano = c.Int(nullable: false),
                        presedencia = c.String(nullable: false, unicode: false),
                        tipo = c.Int(nullable: false),
                        Estudiante_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estudiantes", t => t.Estudiante_Id)
                .Index(t => t.Estudiante_Id);
            
            CreateTable(
                "dbo.Estudiante_trabajo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cargo = c.String(nullable: false, unicode: false),
                        tiepo = c.String(nullable: false, unicode: false),
                        telefono = c.Int(nullable: false),
                        direccion = c.String(nullable: false, unicode: false),
                        Estudiante_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estudiantes", t => t.Estudiante_Id)
                .Index(t => t.Estudiante_Id);
            
            CreateTable(
                "dbo.Padres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Estudiante_Id = c.Int(),
                        Persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Estudiantes", t => t.Estudiante_Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .Index(t => t.Estudiante_Id)
                .Index(t => t.Persona_Id);
            
            CreateTable(
                "dbo.Nacionalidads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pais_Id = c.Int(),
                        Persona_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pais", t => t.Pais_Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .Index(t => t.Pais_Id)
                .Index(t => t.Persona_Id);
            
            CreateTable(
                "dbo.Pais",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        pais = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Email = c.String(maxLength: 256, storeType: "nvarchar"),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(unicode: false),
                        SecurityStamp = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(precision: 0),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256, storeType: "nvarchar"),
                        Persona_Id = c.Int(),
                        Rol_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Personas", t => t.Persona_Id)
                .ForeignKey("dbo.Rols", t => t.Rol_Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex")
                .Index(t => t.Persona_Id)
                .Index(t => t.Rol_Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ClaimType = c.String(unicode: false),
                        ClaimValue = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        ProviderKey = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Rols",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        rol = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        RoleId = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Usuario_opcion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        estado = c.Int(nullable: false),
                        Opcion_Id = c.Int(),
                        User_Id = c.String(maxLength: 128, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Opcions", t => t.Opcion_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Opcion_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Opcions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        opcion = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                        id_padre = c.Int(nullable: false),
                        estado = c.Int(nullable: false),
                        Modulo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Moduloes", t => t.Modulo_Id)
                .Index(t => t.Modulo_Id);
            
            CreateTable(
                "dbo.Moduloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        modulo = c.String(nullable: false, unicode: false),
                        descripcion = c.String(unicode: false),
                        estado = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128, storeType: "nvarchar"),
                        Name = c.String(nullable: false, maxLength: 256, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Usuario_opcion", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Usuario_opcion", "Opcion_Id", "dbo.Opcions");
            DropForeignKey("dbo.Opcions", "Modulo_Id", "dbo.Moduloes");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "Rol_Id", "dbo.Rols");
            DropForeignKey("dbo.AspNetUsers", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Nacionalidads", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.Nacionalidads", "Pais_Id", "dbo.Pais");
            DropForeignKey("dbo.Departamentoes", "Pais_Id", "dbo.Pais");
            DropForeignKey("dbo.Personas", "Municipio_Id", "dbo.Municipios");
            DropForeignKey("dbo.Estudiantes", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.Padres", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.Padres", "Estudiante_Id", "dbo.Estudiantes");
            DropForeignKey("dbo.Estudiante_trabajo", "Estudiante_Id", "dbo.Estudiantes");
            DropForeignKey("dbo.Estudiante_estudio", "Estudiante_Id", "dbo.Estudiantes");
            DropForeignKey("dbo.Docentes", "Persona_Id", "dbo.Personas");
            DropForeignKey("dbo.Docente_estudio", "Docente_Id", "dbo.Docentes");
            DropForeignKey("dbo.Municipios", "Departamento_Id", "dbo.Departamentoes");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Opcions", new[] { "Modulo_Id" });
            DropIndex("dbo.Usuario_opcion", new[] { "User_Id" });
            DropIndex("dbo.Usuario_opcion", new[] { "Opcion_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", new[] { "Rol_Id" });
            DropIndex("dbo.AspNetUsers", new[] { "Persona_Id" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Nacionalidads", new[] { "Persona_Id" });
            DropIndex("dbo.Nacionalidads", new[] { "Pais_Id" });
            DropIndex("dbo.Padres", new[] { "Persona_Id" });
            DropIndex("dbo.Padres", new[] { "Estudiante_Id" });
            DropIndex("dbo.Estudiante_trabajo", new[] { "Estudiante_Id" });
            DropIndex("dbo.Estudiante_estudio", new[] { "Estudiante_Id" });
            DropIndex("dbo.Estudiantes", new[] { "Persona_Id" });
            DropIndex("dbo.Docente_estudio", new[] { "Docente_Id" });
            DropIndex("dbo.Docentes", new[] { "Persona_Id" });
            DropIndex("dbo.Personas", new[] { "Municipio_Id" });
            DropIndex("dbo.Municipios", new[] { "Departamento_Id" });
            DropIndex("dbo.Departamentoes", new[] { "Pais_Id" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Moduloes");
            DropTable("dbo.Opcions");
            DropTable("dbo.Usuario_opcion");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Rols");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Pais");
            DropTable("dbo.Nacionalidads");
            DropTable("dbo.Padres");
            DropTable("dbo.Estudiante_trabajo");
            DropTable("dbo.Estudiante_estudio");
            DropTable("dbo.Estudiantes");
            DropTable("dbo.Docente_estudio");
            DropTable("dbo.Docentes");
            DropTable("dbo.Personas");
            DropTable("dbo.Municipios");
            DropTable("dbo.Departamentoes");
        }
    }
}
