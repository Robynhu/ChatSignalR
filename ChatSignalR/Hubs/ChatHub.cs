using Microsoft.AspNet.SignalR;

namespace ChatSignalR.Hubs
{
    public class ChatHub : Hub
    {
        //Classe responsável pelo Hub do SignalR

        /// <summary>
        /// Função chamada pelo cliente para enviar a mensagens aos outros clientes conectados
        /// </summary>
        /// <param name="user"> Apelido </param>
        /// <param name="msg"> Mensagem </param>
        public void EnviarMsg(string user, string msg)
        {
            Clients.All.enviarMensagem(user, msg);
        }
    }
}