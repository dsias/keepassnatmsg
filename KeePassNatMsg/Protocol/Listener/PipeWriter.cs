﻿using System.IO.Pipes;

namespace KeePassNatMsg.Protocol.Listener
{
    public class PipeWriter : IMessageWriter
    {
        private readonly NamedPipeServerStream _server;
        private readonly System.Text.UTF8Encoding _utf8;

        public PipeWriter(NamedPipeServerStream server)
        {
            _server = server;
            _utf8 = new System.Text.UTF8Encoding(false);
        }

        public void Send(string msg)
        {
            var data = _utf8.GetBytes(msg);
            _server.Write(data, 0, data.Length);
            _server.Flush();
        }
    }
}
