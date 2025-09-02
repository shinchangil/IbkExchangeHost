using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAICurrencyElement
    {
        /// <summary>EAI 통화 기본 클래스</summary>
        /// <param name="packetString">패킷 문자열</param>
        public ibkEAICurrencyElement(Boolean isHost, String packetString)
        {
            Int32 _curIdx = 0;

            if (isHost)
            {
                _curIdx = 1;

                crcd = packetString.Substring(_curIdx, 3);

                _curIdx += 6;
                tlcb_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));
               
                _curIdx += 12;
                tlch_sell_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                csh_bng_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                csh_sell_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 24;
                brgn_base_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                tscn_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));
            }
            else
            {
                _curIdx = 0;

                crcd = packetString.Substring(_curIdx, 3);

                _curIdx += 3;
                brgn_base_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                tscn_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                tlcb_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                tlch_sell_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                csh_bng_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));

                _curIdx += 12;
                csh_sell_rt = Decimal.Parse(packetString.Substring(_curIdx, 12));
            }
        }

        public ibkEAICurrencyElement(Boolean isHost, String packetString, out Boolean isConverted)
        {
            Int32 _curIdx = 0;
            isConverted = false;

            if (isHost)
            {
                _curIdx = 1;

                crcd = packetString.Substring(_curIdx, 3);

                _curIdx += 6;
                Decimal.TryParse(packetString.Substring(_curIdx, 12), out tlcb_rt);

                _curIdx += 12;
                Decimal.TryParse(packetString.Substring(_curIdx, 12), out tlch_sell_rt);

                _curIdx += 12;
                Decimal.TryParse(packetString.Substring(_curIdx, 12), out csh_bng_rt);

                _curIdx += 12;
                Decimal.TryParse(packetString.Substring(_curIdx, 12), out csh_sell_rt);

                _curIdx += 24;
                Decimal.TryParse(packetString.Substring(_curIdx, 12), out brgn_base_rt);

                _curIdx += 12;
                if (Decimal.TryParse(packetString.Substring(_curIdx, 12), out tscn_rt)) isConverted = true;
            }
        }

        /// <summary>통화코드</summary>
        private String crcd;

        /// <summary>통화코드(길이:3)</summary>
        public String CRCD
        {
            get { return crcd; }
            set
            {
                crcd = value;
            }
        }

        /// <summary>매매기준율</summary>
        private Decimal brgn_base_rt;

        /// <summary>매매기준율(길이:12,6)</summary>
        public Decimal BRGN_BASE_RT
        {
            get { return brgn_base_rt; }
            set
            {
                brgn_base_rt = value;
            }
        }

        /// <summary>대미환산율</summary>
        private Decimal tscn_rt;

        /// <summary>대미환산율(길이:12,6)</summary>
        public Decimal TSCN_RT
        {
            get { return tscn_rt; }
            set
            {
                tscn_rt = value;
            }
        }

        /// <summary>전신환매입률</summary>
        private Decimal tlcb_rt;

        /// <summary>전신환매입률(길이:12,6)</summary>
        public Decimal TLCB_RT
        {
            get { return tlcb_rt; }
            set
            {
                tlcb_rt = value;
            }
        }   

        /// <summary>전신환매도율</summary>
        private Decimal tlch_sell_rt;

        /// <summary>전신환매도율(길이:12,6)</summary>
        public Decimal TLCH_SELL_RT
        {
            get { return tlch_sell_rt; }
            set
            {
                tlch_sell_rt = value;
            }
        }

        /// <summary>현찰매입률</summary>
        private Decimal csh_bng_rt;

        /// <summary>현찰매일률(길이:12,6)</summary>
        public Decimal CSH_BNG_RT
        {
            get { return csh_bng_rt; }
            set
            {
                csh_bng_rt = value;
            }
        }

        /// <summary>현찰환매   도율</summary>
        private Decimal csh_sell_rt;

        /// <summary>현찰환매도율(길이:12,6)</summary>
        public Decimal CSH_SELL_RT
        {
            get { return csh_sell_rt; }
            set
            {
                csh_sell_rt = value;
            }
        }
    }
}
