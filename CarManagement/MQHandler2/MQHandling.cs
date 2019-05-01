using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MQHandler2
{
    public class MQHandling<T>
    {
        private string constring = @"FormatName:direct=os:";
        private string mqname = @".\private$\";

        private MessageQueue mq;

        public MQHandling(string mqname)
        {
            this.mqname += mqname;

            if (!MessageQueue.Exists(this.mqname))
            {
                MessageQueue.Create(this.mqname);
            }

            mq = new MessageQueue(constring + this.mqname);
            mq.Formatter = new XmlMessageFormatter(new Type[] { typeof(T) });
        }

        public void Send(T data)
        {
            mq.Send(data);
        }

        public T Read()
        {
            return (T)mq.Receive().Body;
        }
    }
}