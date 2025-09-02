using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAIPacketRequestExchange
    {
        /// <summary>전문 종료 코드</summary>
        const String EndCode = "@@";

        /// <summary>생성자</summary>
        public ibkEAIPacketRequestExchange()
        {
            dtst_dcd = "IO";

            //  조회거래구분코드(길이 : 2)
            iqtr_dcd = "03";

            //  조회년뭘일(길이 : 8)
            inq_ymd = DateTime.Today.ToString("yyyyMMdd");

            //  조회년뭘(길이 : 6)
            inq_ym = "      ";

            //  기준통화코드(길이 : 3)
            base_crcd = "   ";

            //  상대통화코드(길이 : 3)
            cocu_cd = "   ";

            //  환뮬종류코드(길이 : 2)
            xrt_kcd = "   ";

            //  환율구분코드(길이 : 2)
            xrt_dcd = "  ";

            //  고시회차(길이 : 5)
            bltn_tob = "     ";

            //  본지점고시회차(길이 : 5)
            hdbr_bltn_tob = "     ";

            //  일별최종고시회차(길이 : 5)
            dtp_last_bltn_tob = "     ";

            //  일별최종본지점고시회차(길이 : 5)
            dtp_last_hdbr_bltn_tob = "     ";

            //  정렬방법코드(길이 : 1)
            lnp_mcd = " ";

            //  출력구분코드(길이 : 1)
            otpt_dcd = " ";

            base_ymd = DateTime.Today.ToString("yyyyMMdd");
        }
        
        //  공통 코드

        /// <summary>데이터셋구분코드</summary>
        private String dtst_dcd;

        /// <summary>데이터셋구분코드(길이:2, 오프셋:0)</summary>
        public String DTST_DCD
        {
            get { return dtst_dcd.PadLeft(2, '0'); }
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

        public String DTST_LEN_STR { get { return DTST_LEN.ToString().PadLeft(6, '0'); } }

        //  여기부터 카투스 데이터

        /// <summary>기준 년월일</summary>
        private String base_ymd;

        /// <summary>기준 년월일(길이:8, 오프셋:8)</summary>
        public String BASE_YMD
        {
            get { return base_ymd.PadLeft(8, ' '); }
            set
            {
                base_ymd = value;
            }
        }

        //  여기부터 계정계 데이터

        /// <summary>조회거래구분코드(길이 : 2)</summary>
        private String iqtr_dcd;

        /// <summary>조회거래구분코드(길이 : 2)</summary>
        public String IQTR_DCD
        {
            get { return iqtr_dcd.PadLeft(2, ' '); }
            set
            {
                iqtr_dcd = value;
            }
        }

        /// <summary>조회년뭘일(길이 : 8)</summary>
        private String inq_ymd;

        /// <summary>조회년뭘일(길이 : 8)</summary>
        public String INQ_YMD
        {
            get { return inq_ymd.PadLeft(8, ' '); }
            set
            {
                inq_ymd = value;
            }
        }

        /// <summary>조회년뭘(길이 : 6)</summary>

        private String inq_ym;

        /// <summary>조회년뭘(길이 : 6)</summary>
        public String INQ_YM
        {
            get {  return inq_ym.PadLeft(6, ' '); }
            set
            {
                inq_ym = value;
            }
        }

        /// <summary>기준통화코드(길이 : 3)</summary>
        private String base_crcd; 

        /// <summary>기준통화코드(길이 : 3)</summary>
        public String BASE_CRCD
        {
            get { return base_crcd.PadLeft(3, ' '); }
            set { base_crcd = value; }
        }

        /// <summary>상대통화코드(길이 : 3)</summary>
        private String cocu_cd;

        /// <summary>상대통화코드(길이 : 3)</summary>
        public String COCU_CD
        {
            get { return cocu_cd.PadLeft(3, ' '); }
            set
            {
                cocu_cd = value;
            }
        }

        /// <summary>환뮬종류코드(길이 : 2)</summary>
        private String xrt_kcd;

        /// <summary>환뮬종류코드(길이 : 2)</summary>
        public String XRT_KCD
        {
            get { return xrt_kcd.PadLeft(2, ' '); }
            set
            {
                xrt_kcd = value;
            }
        }

        /// <summary>환율구분코드(길이 : 2)</summary>
        private String xrt_dcd;

        /// <summary>환율구분코드(길이 : 2)</summary>
        public String XRT_DCD
        {
            get { return xrt_dcd.PadLeft(2, ' '); }
            set
            {
                xrt_dcd = value;
            }
        }

        /// <summary>고시회차(길이 : 5)</summary>
        private String bltn_tob;

        /// <summary>고시회차(길이 : 5)</summary>
        public String BLTN_TOB
        {
            get { return bltn_tob; }
            set 
            { 
            bltn_tob = value;
            }
        }

        public String BLTN_TOB_STR { get { return BLTN_TOB.ToString().PadLeft(5, ' '); } }

        /// <summary>본지점고시회차(길이 : 5)</summary>
        private String hdbr_bltn_tob;

        /// <summary>본지점고시회차(길이 : 5)</summary>
        public String HDBR_BLTN_TOB
        {
            get { return hdbr_bltn_tob; }
            set
            {
                hdbr_bltn_tob= value;
            }
        }

        public String HDBR_BLTN_TOB_STR { get { return HDBR_BLTN_TOB.ToString().PadLeft(5, ' '); } }


        /// <summary>일별최종고시회차(길이 : 5)</summary>
        private String dtp_last_bltn_tob;

        /// <summary>일별최종고시회차(길이 : 5)</summary>
        public String DTP_LAST_BLTN_TOB
        {
            get { return dtp_last_bltn_tob; }

            set 
            { 
                dtp_last_bltn_tob = value; 
            }
        }

        public String DTP_LAST_BLTN_TOB_STR { get { return DTP_LAST_BLTN_TOB.ToString().PadLeft(5, ' '); } }


        /// <summary>일별최종본지점고시회차(길이 : 5)</summary>
        private String dtp_last_hdbr_bltn_tob;

        /// <summary>일별최종본지점고시회차(길이 : 5)</summary>
        public String DTP_LAST_HDBR_BLTN_TOB
        {
            get { return dtp_last_hdbr_bltn_tob; }

            set
            {
                dtp_last_hdbr_bltn_tob = value;
            }
        }

        public String DTP_LAST_HDBR_BLTN_TOB_STR { get { return DTP_LAST_HDBR_BLTN_TOB.ToString().PadLeft(5, ' '); } }

        /// <summary>정렬방법코드(길이 : 1)</summary>
        private String lnp_mcd;

        /// <summary>정렬방법코드(길이 : 1)</summary>
        public String LNP_MCD
        {
            get { return lnp_mcd.PadLeft(1, ' '); }
            set 
            { 
                lnp_mcd = value; 
            }
        }

        /// <summary>출력구분코드(길이 : 1)</summary>
        private String otpt_dcd;

        /// <summary>출력구분코드(길이 : 1)</summary>
        public String OTPT_DCD
        {
            get { return otpt_dcd.PadLeft(1, ' '); }
            set
            {
                otpt_dcd = value;
            }
        }


        /// <summary>패킷 헤더 전문</summary>
        public String GetPacket(Boolean isHost, String date)
        {
            if(!String.IsNullOrWhiteSpace(date))
            {
                base_ymd = date;
                inq_ymd = date;
                inq_ym = date.Substring(0, 6);
            }

            if (isHost == false)
            {
                dtst_len = BASE_YMD.Length;

                return DTST_DCD + DTST_LEN_STR + BASE_YMD + EndCode;
            }
            else
            {
                var _packetStr = 
                    IQTR_DCD
                        + INQ_YMD
                        + INQ_YM
                        + BASE_CRCD
                        + COCU_CD
                        + XRT_KCD
                        + XRT_DCD
                        + BLTN_TOB_STR
                        + HDBR_BLTN_TOB_STR
                        + DTP_LAST_BLTN_TOB_STR
                        + DTP_LAST_HDBR_BLTN_TOB_STR
                        + LNP_MCD
                        + OTPT_DCD;

                dtst_len = _packetStr.Length;

                return DTST_DCD + DTST_LEN_STR + _packetStr + EndCode;
            }
        }
    }
}
