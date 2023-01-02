--select * from Utilisateurs
create 

       procedure 
                 sp_Update_Utilisateurs
(@nom nvarchar(20),@prénom nvarchar(20),@AdressMail nvarchar(20),@Nmatricule nvarchar(20),@mtdpass nvarchar(20),@newnom nvarchar(20),@newprénom nvarchar(20),@newAdressMail nvarchar(20),@newNmatricule nvarchar(20),@newmtdpass nvarchar(20))

as

update  Utilisateurs set 
                   nom=@newnom,
				   prénom=@newprénom,
				   AdressMail=@newAdressMail,
				   Nmatricule=@newNmatricule,
				   mtdpass=@newmtdpass,
				   

