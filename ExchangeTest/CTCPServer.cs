using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    /// <summary>TCP 수신 서버</summary>
    public class CTCPServer
    {
        NLog.Logger logger = LogManager.GetCurrentClassLogger();
        TcpListener server = null;
        public bool bTerminated = false;
        int port = 0;
        string ip = "127.0.0.1";

        /// <summary>생성자</summary>
        /// <param name="IP">IP 주송</param>
        /// <param name="Port">포트 번호</param>
        public CTCPServer(string IP, int Port)
        {
            ip = IP;
            port = Port;
        }

        /// <summary>실행 함수</summary>
        public void Execute()
        {
            logger.Info($"Listen Server Start");

            bool bStart = ActiveServer();
            Byte[] bytes = new Byte[3000];
            String data = null;

            while (!bTerminated)
            {
                TcpClient client = server.AcceptTcpClient();

                logger.Info($"Connect Client");

                data = null;

                NetworkStream stream = client.GetStream();

                int i;

                try
                {
                    // 받은데이터 전송
                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        // 데이터 읽기
                        data = Encoding.UTF8.GetString(bytes, 0, i);
                        Console.WriteLine("Received: {0}", data);
                        logger.Info($"Data Received {data}");
                        // 수신 데이터 재전송
                        //byte[] msg = Encoding.UTF8.GetBytes(data);
                        //stream.Write(msg, 0, msg.Length);
                        //Console.WriteLine("Sent: {0}", data);
                    }

                }
                catch (Exception)
                {

                }

                client.Close();
            }

        }

        private bool ActiveServer()
        {
            bool bResult = false;
            IPAddress localAddr = IPAddress.Parse(ip);
            try
            {
                server = new TcpListener(localAddr, port);
            }
            catch (Exception e)
            {
                logger.Error("ActiveServer : " + e.Message);
            }
            try
            {
                server.Start();
            }
            catch (Exception e2)
            {
                logger.Error("ActiveServer : " + e2.Message);
            }
            return bResult;
        }
    }
}
