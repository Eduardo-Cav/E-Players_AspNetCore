using System.Collections.Generic;
using E_Players_AspNetCore.Models;

namespace E_Players_AspNetCore.Interfaces
{
    public interface IJogador
    {
        void Create(Jogador player);

        List<Jogador> ReadAll();

        void Update(Jogador playerU);

        void Delete(int id);
    }
}