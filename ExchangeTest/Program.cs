using NLog;
using System.Net.Sockets;
using System.Net;
using System.Text;


/*
 case 1: 기본 인코딩
    - Encoding euckr = Encoding.UTF8; 
 case 2: 한글 인코딩
    - Encoding.GetEncoding("euc-kr").GetString(...);
 case 3: 한글 인코딩
    - Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      Encoding euckr = Encoding.GetEncoding(949);
*/
namespace ExchangeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int encoding_case = 1;
            //  DB에 넣어서 부를때 마다 증가하도록 설정
            Int32 requestSeq = 0;

            //  EAI 서버 주소 환경설정으로 이동
            //String ipAddress = "172.18.190.83";
            String ipAddress = "";

            ///docker 올리기
            ///docker run -itd --name catus -v `pwd`:/home/castware/agent rockeybaseimage:1.0
            ///docker exec -it catus /bin/bash
            ///docker 내부 경로: /home/castware/agent
            /////////////////////////////////////////////////////////////////////////////////////////////////
            ///로그 파일을 위한
            var current = AppDomain.CurrentDomain.BaseDirectory;
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "log"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "log");
            }

            LogManager.Setup().LoadConfigurationFromFile("nlogCatus.config");
            var logger = LogManager.GetCurrentClassLogger();
            /////////////////////////////////////////////////////////////////////////////////////////////////
            ///환경설정 파일 읽고 쓰기
            CFileConfig cFileConfig = new CFileConfig(AppDomain.CurrentDomain.BaseDirectory + "myConf.ini");
            //cFileConfig.MyWriteIni("http://", "testError");
            cFileConfig.LoadIni();
            //logger.Info("Play url : " + cFileConfig.Play_URL);
            //logger.Info("WriteTime : " + cFileConfig.WriteTime);
            //logger.Info("ErrCode : " + cFileConfig.ErrCode);
            /////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            ///TCP Server
            //CTCPServer server = new CTCPServer("0.0.0.0", cFileConfig.EaiListenPort);
            //Thread threadServer = new Thread(server.Execute);
            //threadServer.IsBackground = true;
            //threadServer.Start();
            //Thread.Sleep(6000);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            ibkEAIPacketRequest1 _base1 = new ibkEAIPacketRequest1(
                requestSeq, 
                cFileConfig.EaiListenIpAddress, 
                cFileConfig.EaiListenMac, 
                cFileConfig.EaiIpaddress, 
                cFileConfig.EaiListenPort
            );
        
            ibkEAIPacketRequest2 _base2 = new ibkEAIPacketRequest2();
            ibkEAIPacketRequest3 _base3 = new ibkEAIPacketRequest3();
            ibkEAIPacketRequestExchange _request = new ibkEAIPacketRequestExchange();

            String _date = String.Empty;
            Int32 _startPos = 0;
            Boolean _isHost = true;

            if (args.Length == 1)
            {
                encoding_case = int.Parse(args[0]);
            }

            //if (args.Length == 2) 
            //{
            //    _isHost = Boolean.Parse(args[0]);
            //    _date = args[1];
            //}

            var _sendPacket = _base1.GetPacket(_isHost, _base2.GetPacket() + _base3.GetPacket() + _request.GetPacket(_isHost, _date));

            String _sample = String.Empty;

            //var 
            //var _hostSample = @"009313Y1KO02420241101NFB00000280067160000030000000420241101NFB00000020241101144035764172.18.121.197                         005056803AABD20241101144035764N000EAI0000000020241106144038138R00000NFBNFBNFBO00084444SN020241101144035764CBKFEX508012                                172.18.190.83                          09999dmca0101CBK2024110614403810300               NFBNFBNFB0000000000000000000000 N20241101NFBO00083530000000000000                      OLTNFBCBKFEX508012800800      000000000N100000000001001000                                                                                                                                                                                                MC0001240885C06  0000FS04240311                                  0000000N0885000000000-99999999999999-99999999999999-99999999999999NNC000597                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                00000                                                                                                                OF0000180101         0 000IO0078460885�۷ι��ڱݱ�                                      20241106144035C0603                                                                                                                                    2024110611553001794      0179400000                                                                                                    00688.10000000451.99000002339.54000001536.74000000058 USDKRW01363.20000001389.20000001352.12000001400.28000000000.00000001376.20000000001.00000000006.64050001376.2000000017500175*JPYKRW00895.39000000912.55000000888.16000000919.78000000000.00000000903.97000000000.65690000002.18460000152.2400000017500175 EURKRW01481.99000001510.41000001466.73000001525.67000000000.00000001496.20000000001.08720000005.09800000001.0872000019700197 GBPKRW01765.66000001799.52000001747.48000001817.70000000000.00000001782.59000000001.29530000006.84000000001.2953000019700197 AUDKRW00898.58000000915.80000000889.41000000924.97000000000.00000000907.19000000000.65920000006.30960000000.6592000019600196 NZDKRW00816.25000000831.89000000807.92000000840.22000000000.00000000824.07000000000.59880000006.77000000000.5988000019600196 CHFKRW01571.33000001601.47000001555.31000001617.49000000000.00000001586.40000000001.15270000002.71000000000.8675000019600196 CADKRW00979.19000000997.97000000969.21000001007.95000000000.00000000988.58000000000.71830000005.71000000001.3921000019600196 DKKKRW00198.80000000202.60000000196.69000000204.71000000000.00000000200.70000000000.14580000005.10670000006.8571000020000200 NOKKRW00123.76000000126.12000000122.45000000127.43000000000.00000000124.94000000000.09080000006.68000000011.0150000020000200 SEKKRW00127.54000000129.98000000126.19000000131.33000000000.00000000128.76000000000.09360000004.93000000010.6881000020000200 HKDKRW00175.29000000178.65000000173.51000000180.43000000000.00000000176.97000000000.12860000006.05000000007.7766000019600196 SGDKRW01030.88000001050.64000001020.26000001061.26000000000.00000001040.76000000000.75630000005.28000000001.3223000019700197 THBKRW00040.28000000041.04000000038.23000000043.09000000000.00000000040.66000000000.02950000004.30000000033.8500000060000600 SARKRW00362.94000000369.90000000342.61000000381.07000000000.00000000366.42000000000.26630000007.51000000003.7557500065000400 AEDKRW00371.13000000378.23000000355.95000000389.66000000000.00000000374.68000000000.27230000005.10000000003.6730000050000400 KWDKRW04446.96000004532.26000004175.34000004669.19000000000.00000004489.61000000003.26230000004.50000000000.3065300070000400 BHDKRW03615.44000003684.78000003358.11000003796.11000000000.00000003650.11000000002.65230000008.38000000000.3770300080000400 MYRKRW00311.40000000317.36000000298.67000000326.95000000000.00000000314.38000000000.22840000005.29000000004.3775000050000400*IDRKRW00008.67000000008.83000000008.23000000009.27000000000.00000000008.75000000000.00640000008.65000015                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ";

            //if (_isHost)
            //{
            //    _startPos = 1463;
            //    _sample = @"009313Y1KO02420241101NFB00000280067160000030000000420241101NFB00000020241101144035764172.18.121.197                         005056803AABD20241101144035764N000EAI0000000020241106144038138R00000NFBNFBNFBO00084444SN020241101144035764CBKFEX508012                                172.18.190.83                          09999dmca0101CBK2024110614403810300               NFBNFBNFB0000000000000000000000 N20241101NFBO00083530000000000000                      OLTNFBCBKFEX508012800800      000000000N100000000001001000                                                                                                                                                                                                MC0001240885C06  0000FS04240311                                  0000000N0885000000000-99999999999999-99999999999999-99999999999999NNC000597                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                00000                                                                                                                OF0000180101         0 000IO0078460885�۷ι��ڱݱ�                                      20241106144035C0603                                                                                                                                    2024110611553001794      0179400000                                                                                                    00688.10000000451.99000002339.54000001536.74000000058 USDKRW01363.20000001389.20000001352.12000001400.28000000000.00000001376.20000000001.00000000006.64050001376.2000000017500175*JPYKRW00895.39000000912.55000000888.16000000919.78000000000.00000000903.97000000000.65690000002.18460000152.2400000017500175 EURKRW01481.99000001510.41000001466.73000001525.67000000000.00000001496.20000000001.08720000005.09800000001.0872000019700197 GBPKRW01765.66000001799.52000001747.48000001817.70000000000.00000001782.59000000001.29530000006.84000000001.2953000019700197 AUDKRW00898.58000000915.80000000889.41000000924.97000000000.00000000907.19000000000.65920000006.30960000000.6592000019600196 NZDKRW00816.25000000831.89000000807.92000000840.22000000000.00000000824.07000000000.59880000006.77000000000.5988000019600196 CHFKRW01571.33000001601.47000001555.31000001617.49000000000.00000001586.40000000001.15270000002.71000000000.8675000019600196 CADKRW00979.19000000997.97000000969.21000001007.95000000000.00000000988.58000000000.71830000005.71000000001.3921000019600196 DKKKRW00198.80000000202.60000000196.69000000204.71000000000.00000000200.70000000000.14580000005.10670000006.8571000020000200 NOKKRW00123.76000000126.12000000122.45000000127.43000000000.00000000124.94000000000.09080000006.68000000011.0150000020000200 SEKKRW00127.54000000129.98000000126.19000000131.33000000000.00000000128.76000000000.09360000004.93000000010.6881000020000200 HKDKRW00175.29000000178.65000000173.51000000180.43000000000.00000000176.97000000000.12860000006.05000000007.7766000019600196 SGDKRW01030.88000001050.64000001020.26000001061.26000000000.00000001040.76000000000.75630000005.28000000001.3223000019700197 THBKRW00040.28000000041.04000000038.23000000043.09000000000.00000000040.66000000000.02950000004.30000000033.8500000060000600 SARKRW00362.94000000369.90000000342.61000000381.07000000000.00000000366.42000000000.26630000007.51000000003.7557500065000400 AEDKRW00371.13000000378.23000000355.95000000389.66000000000.00000000374.68000000000.27230000005.10000000003.6730000050000400 KWDKRW04446.96000004532.26000004175.34000004669.19000000000.00000004489.61000000003.26230000004.50000000000.3065300070000400 BHDKRW03615.44000003684.78000003358.11000003796.11000000000.00000003650.11000000002.65230000008.38000000000.3770300080000400 MYRKRW00311.40000000317.36000000298.67000000326.95000000000.00000000314.38000000000.22840000005.29000000004.3775000050000400*IDRKRW00008.67000000008.83000000008.23000000009.27000000000.00000000008.75000000000.00640000008.65000015                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               ";
            //}
            //else
            //{ 
            //    _startPos = 1437;
            //    _sample = @"002059N0KO02420240807NFB00000280067160000030000000320240807NFB00000020240807065328261172.18.202.28                          ************D20240807155328312N000EAI0000000020240807155328437R00000NFBCTANFBO00083530SN020240807155328312                                    00000000                                       00000        CTS2024080715532831200               NFBNFBNFB                                                      00                      OLTNFB                                  100000000000001000                                                                                                                                                                                                MC000124         0000CHCTS00011        22                        0000000           000000000000000000000000000000000000000000000000 NC000597                                                                                                      ********************                    ****************                                                                                                                                                                                                                                                                                                                                  00000                                                                                                                IO000618202408070095600008USD01378.10000000001.00000001365.10000001391.10000001353.99000001402.210000JPY00938.25000000146.88000000929.34000000947.16000000921.84000000954.660000CNY00191.77000000007.18640000189.95000000193.59000000182.19000000201.350000EUR01502.96000000001.09060001488.69000001517.23000001473.36000001532.560000GBP01750.05000000001.26990001733.43000001766.67000001715.58000001784.520000CAD01000.15000000001.37790000990.65000001009.65000000980.55000001019.750000AUD00902.52000000000.65490000893.95000000911.09000000884.84000000920.200000CHF01608.05000000000.85700001592.78000001623.32000001576.54000001639.560000@@";
            //}


            //ibkEAIPacketResponse _response1 = new ibkEAIPacketResponse(_isHost, _sample, _startPos);

            //logger.Info($"Result: \"{_response1.GetData(_isHost)}\"");

            logger.Info(cFileConfig.EaiIpaddress);
            logger.Info(cFileConfig.EaiListenMac);
            logger.Info(cFileConfig.EaiListenPort);


            try
            {
                logger.Trace($"Assembled Packet : {_sendPacket}");

                logger.Info($"Send Start");

                // localhost ,13000 통신 연결 요청
                TcpClient client = new TcpClient(cFileConfig.EaiIpaddress, cFileConfig.EaiSendPort);

                logger.Info($"Send Start - 2");
                // 입장시 Hello 전달
                Byte[] _data =
                    Encoding.UTF8.GetBytes(_sendPacket);

                logger.Trace($"Assembled Packet - Encoded : {_data}");

                logger.Info($"Send Start - 3");

                NetworkStream stream = client.GetStream();

                logger.Info($"Send End");


                // 서버로 전송
                stream.WriteAsync(_data, 0, _data.Length).GetAwaiter();

                logger.Info($"Send End");
                // 수신 데이터 선언
                _data = new Byte[10 * 1024];

                // 수신 데이터 스트링 선언
                string responseData = string.Empty;

                logger.Info($"Recv Encoding Start");

                // 수신된 데이터 스트링으로 변환
                var _recv = stream.ReadAsync(_data, 0, _data.Length).GetAwaiter();
                logger.Info($"Recv Encoding Working 1 " + _recv.GetResult());

                var _length = "";
                var _packetCount = 0;
                ibkEAIPacketResponse _response = null;
                switch (encoding_case)
                {
                    case 1:
                        _length = Encoding.UTF8.GetString(_data, 0, 6);
                        logger.Info($"Recv Encoding Working 2 " + _length);

                        _packetCount = Int32.Parse(_length) + 6;

                        logger.Info($"Recv Encoding Working 3 " + _packetCount);

                        responseData = Encoding.UTF8.GetString(_data, 0, _packetCount);

                        logger.Info($"Message received: \"{responseData}\"");

                        _response = new ibkEAIPacketResponse(_isHost, responseData, 1437);

                        logger.Info($"Currency Count Result: \"{_response.GetData(_isHost)}\"");
                        break;
                    case 2:
                        _length = Encoding.GetEncoding("euc-kr").GetString(_data, 0, 6);
                        logger.Info($"Recv Encoding Working 2 " + _length);

                        _packetCount = Int32.Parse(_length) + 6;

                        logger.Info($"Recv Encoding Working 3 " + _packetCount);

                        responseData = Encoding.GetEncoding("euc-kr").GetString(_data, 0, _packetCount);

                        logger.Info($"Message received: \"{responseData}\"");

                        _response = new ibkEAIPacketResponse(_isHost, responseData, 1437);

                        logger.Info($"Currency Count Result: \"{_response.GetData(_isHost)}\"");
                        break;
                    case 3:
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                        Encoding euckr = Encoding.GetEncoding(949);
                        _length = euckr.GetString(_data, 0, 6);
                        logger.Info($"Recv Encoding Working 2 " + _length);

                        _packetCount = Int32.Parse(_length) + 6;

                        logger.Info($"Recv Encoding Working 3 " + _packetCount);

                        responseData = euckr.GetString(_data, 0, _packetCount);

                        logger.Info($"Message received: \"{responseData}\"");

                        _response = new ibkEAIPacketResponse(_isHost, responseData, 1437);

                        logger.Info($"Currency Count Result: \"{_response.GetData(_isHost)}\"");
                        break;
                    
                    default:
                        break;
                }
                

                
                
                

                 

                

            }
            catch (Exception e)
            {
               logger.Info($"Error: \"{e.Data}\"");
            }


            ///서버 클래스 운영을 위해 떠 있어야 함. 그래서 꺼지지 않게 방지
            Console.ReadLine();
            try
            {
                //threadServer.Abort();

            }
            catch (Exception)
            {

            }
            //threadServer.Join();
        }
    }
}
