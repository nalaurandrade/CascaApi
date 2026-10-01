using CascaApi.Models;

namespace CascaApi.Repository
{
    public interface IJogadorRepository
    {
        public List<Jogador> ListarJogadores();
        public void Cadastrar(Jogador jogador);
        public Jogador Consultar(string nome);
    }
}
