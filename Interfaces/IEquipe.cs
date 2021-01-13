using System.Collections.Generic;
using E_Players_AspNetCore.Models;

namespace E_Players_AspNetCore.Interfaces
{
    public interface IEquipe
    {
         //CRUD
         void Create(Equipe team);

         List<Equipe> ReadAll();

         void Update(Equipe teamU);

         void Delete(int id);
    }
}