Imports System
Imports System.Data.Entity.Migrations
Imports Microsoft.VisualBasic

Namespace Migrations
    Public Partial Class AddCampos
        Inherits DbMigration
    
        Public Overrides Sub Up()
            AddColumn("dbo.AspNetUsers", "CPF", Function(c) c.String())
        End Sub
        
        Public Overrides Sub Down()
            DropColumn("dbo.AspNetUsers", "CPF")
        End Sub
    End Class
End Namespace
