using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capys.Pleno.DAL.Repositories
{
    public class UsuarioEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public UsuarioEntity(int _id, string _name, string _email, string _password)
        {
            Id = _id;
            Name = _name;
            Email = _email;
            Password = _password;
        }
    }
    public class UsuariosRepository
    {
        private List<UsuarioEntity> lstUsuarios = new List<UsuarioEntity>()
        {
            new UsuarioEntity(1, "willian", "willian@hotmail.com", "asd123!&")
        };

        public UsuarioEntity InserirUsuarios(UsuarioEntity request)
        {
            lstUsuarios.Add(request);
            return request;
        }



    }
}
