using IniParser.Model;
using IniParser;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExchangeTest
{
    public class CFileConfig
    {
        /// <summary>로그</summary>
        NLog.Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>로그 경로</summary>
        private String path;

        /// <summary>URL</summary>
        public String Play_URL { get; set; }

        /// <summary>쓰기 기산</summary>
        public String WriteTime { get; set; }

        /// <summary>에러 코드</summary>
        public String ErrCode { get; set; }

        /// <summary>EAI 서버 IP 주소</summary>
        public String EaiIpaddress { get; set; }

        /// <summary>EAI 전송 서버 포트 주소</summary>
        public Int32 EaiSendPort { get; set; }

        /// <summary>EAI 수신 IP 주소</summary>
        public String EaiListenIpAddress { get; set; }

        /// <summary>EAI 수신 서버 포트 주소</summary>
        public Int32 EaiListenPort { get; set; }

        /// <summary>EAI 수신 서버 MAC 주소</summary>
        public String EaiListenMac {  get; set; }

        /// <summary>환경설정 생성자</summary>
        /// <param name="path">경로</param>
        public CFileConfig(string path)
        {
            this.path = path;
        }

        //파일 첫줄이 비어있어야 한다.(엔터)
        /// <summary>환경설정 쓰기</summary>
        /// <param name="url">경로</param>
        /// <param name="error">에러 코드</param>
        public void MyWriteIni(string url, string error = "")
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = new IniData();
                data["Content"]["URL"] = url;
                data["Content"]["When"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                data["Content"]["ErrCode"] = error;
                //data["Content"]["EaiIpAddress"] = EaiIpaddress;
                //data["Content"]["EaiRealPort"] = EaiRealPort.ToString();
                //data["Content"]["EaiSendPort"] = EaiSendPort.ToString();

                parser!.WriteFile(path, data);
            }
            catch (Exception e)
            {
                logger.Error(url);
                logger.Error(e.Message);
            }
        }

        /// <summary>환경설정 읽어오기</summary>
        public void LoadIni()
        {
            try
            {
                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(path);
                Play_URL = data["Content"]["URL"];
                WriteTime = data["Content"]["When"];
                ErrCode = data["Content"]["ErrCode"];
                EaiIpaddress = data["Content"]["EaiIpAddress"];
                EaiSendPort = Int32.Parse(data["Content"]["EaiSendPort"]);
                EaiListenIpAddress = data["Content"]["EaiListenIpAddress"];
                EaiListenPort = Int32.Parse(data["Content"]["EaiListenPort"]);
                EaiListenMac = data["Content"]["EaiListenMac"];
            }
            catch (Exception e)
            {
                logger.Error($"Load Config Error - {e.Message}");
            }
        }
    }
}
