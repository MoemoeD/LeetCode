using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public abstract class Server
    {
        public string info { get; set; }

        public Server(string info)
        {
            this.info = info;
        }

        private List<IClient> observers = new List<IClient>();

        public void Add(IClient ob)
        {
            observers.Add(ob);
        }

        public void Remove(IClient ob)
        {
            observers.Remove(ob);
        }

        public void Send()
        {
            foreach (var ob in observers)
            {
                ob.Receive(this);
            }
        }
    }

    public class ServerI : Server
    {
        public ServerI(string info)
            : base(info)
        {

        }
    }

    public interface IClient
    {
        void Receive(Server s);
    }

    public class ClientI : IClient
    {
        public string clientName { get; set; }

        public ClientI(string clientName)
        {
            this.clientName = clientName;
        }

        public void Receive(Server server)
        {
            Console.WriteLine("{0}receive{1}", this.clientName, server.info);
        }
    }
}
