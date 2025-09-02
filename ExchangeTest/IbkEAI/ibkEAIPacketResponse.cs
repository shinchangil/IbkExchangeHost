using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAIPacketResponse
    {
        /// <summary>패킷 중 데이터 시작 인덱스 값</summary>
        private Int32 dataStartIndex = 0;

        /// <summary>패킷 전제 문자열</summary>
        private String packetString = String.Empty;

        /// <summary>환율 관려 문자열</summary>
        private String currencyString = String.Empty;

        /// <summary>생성자</summary>
        /// <param name="isHost">계정계 여부</param>
        /// <param name="packet">패킷 전체 문자열</param>
        /// <param name="dataStartIdx">데이터 시작 인덱스 값</param>
        public ibkEAIPacketResponse(Boolean isHost, String packet, Int32 dataStartIdx)
        {
            Int32 _curIdx = 0;

            var _subString = packet.Substring(dataStartIdx, packet.Length - dataStartIdx);
            
            packetString = packet;
            dataStartIndex = dataStartIdx;

            dtst_dcd = packetString.Substring(dataStartIndex, 2);
            
            _curIdx = dataStartIndex + 2;
            
            dtst_len = Int32.Parse(packetString.Substring(_curIdx, 6));

            if (!isHost) 
            {
                _curIdx += 6;
                base_ymd = packetString.Substring(_curIdx, 8);

                _curIdx += 8;

                var _tob = packetString.Substring(_curIdx, 5);

                bltn_tob = Int32.Parse(_tob);

                _curIdx += 5;
                list_rowcount = Int32.Parse(packetString.Substring(_curIdx, 5));

                _curIdx += 5;

                if (0 == list_rowcount) currencyString = String.Empty;

                else currencyString = packetString.Substring(_curIdx, packet.Length - _curIdx);
            }
            else
            {
                _curIdx += 207;
                base_ymd = packetString.Substring(_curIdx, 8);

                _curIdx += 14;

                var _tob = packetString.Substring(_curIdx, 5);

                bltn_tob = Int32.Parse(_tob);

                _curIdx += 169;

                var _rowCnt = packetString.Substring(_curIdx, 5);

                list_rowcount = Int32.Parse(_rowCnt);

                _curIdx += 5;

                if (0 == list_rowcount) currencyString = String.Empty;

                else currencyString = packetString.Substring(_curIdx, list_rowcount*125);
            }


        }


        /// <summary>데이터셋구분코드</summary>
        private String dtst_dcd;

        /// <summary>데이터셋구분코드(길이:2, 오프셋:0)</summary>
        public String DTST_DCD
        {
            get { return dtst_dcd; }
            set
            {
                dtst_dcd = value;
            }
        }

        /// <summary>데이터셋길이</summary>
        private Int32 dtst_len;

        /// <summary>데이터셋길이(길이:6, 오프셋:2)</summary>
        public Int32 DTST_LEN
        {
            get { return dtst_len; }
            set
            {
                dtst_len = value;
            }
        }
        
        /// <summary>기준 년월일</summary>
        private String base_ymd;

        /// <summary>기준 년월일(길이:8, 오프셋:8)</summary>
        public String BASE_YMD
        {
            get { return base_ymd; }
            set
            {
                base_ymd = value;
            }
        }

        /// <summary>고시회차</summary>
        private int bltn_tob;

        /// <summary>고시회차(길이:5)</summary>
        public Int32 BLTN_TOB
        {
            get { return bltn_tob; }
            set 
            { 
                bltn_tob = value; 
            }
        }

        /// <summary>리스트_배열</summary>
        private Int32 list_rowcount;

        /// <summary>리스트_배열(길이:5)</summary>
        public Int32 LIST_ROWCOUNT
        {
            get { return list_rowcount; }
            set 
            { 
                list_rowcount = value; 
            }
        }


        /// <summary>패킷 헤더 전문</summary>
        public String GetData(Boolean isHost)
        {
            ibkEAICurrencyElement _currency;
            List<ibkEAICurrencyElement> _currencylist;

            String _result = String.Empty;

            if (currencyString.Length == 0) return "0";

            else if (!isHost)
            {
                _currencylist = new List<ibkEAICurrencyElement>();

                var _currArr = Split(currencyString, 75); 

                if(null != _currArr)
                {
                    for (int _count = 0; _count < _currArr.Count(); _count++)
                    {
                        _currencylist.Add(_currency = new ibkEAICurrencyElement(isHost, _currArr.ElementAt(_count)));
                    }
                }

                //  ibkEAICurrencyElement를 이용한 파싱 구문 추가 필요
                _result = _currencylist.Count.ToString();

                return _result;
            }
            else
            {
                _currencylist = new List<ibkEAICurrencyElement>();

                var _currArr = Split(currencyString, 125);

                if (null != _currArr)
                {
                    for (int _count = 0; _count < _currArr.Count(); _count++)
                    {
                        var _curStr = _currArr.ElementAt(_count);
                     
                        if (!String.IsNullOrWhiteSpace(_curStr))
                            _currencylist.Add(_currency = new ibkEAICurrencyElement(isHost, _curStr));
                    }
                }

                //  ibkEAICurrencyElement를 이용한 파싱 구문 추가 필요
                _result = _currencylist.Count.ToString();

                return _result;
            }
        }

        /// <summary>문자열 자르기</summary>
        /// <param name="str">문자열</param>
        /// <param name="chunkSize">기준 사이즈</param>
        /// <returns>문자 배열</returns>
        private IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
