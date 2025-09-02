using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAIPacketRequest2
    {
        /// <summary>기본 생성자</summary>
        public ibkEAIPacketRequest2()
        {
            /// <summary>데이터셋구분코드</summary>
            dtst_dcd = "MC";
            /// <summary>데이터셋길이</summary>
            dtst_len = 000124;
            /// <summary>단말설치부점코드</summary>
            trmn_inlt_brcd = "0885";
            /// <summary>단말번호</summary>
            tmn = "C06";
            /// <summary>신분증스캔일련번호</summary>
            idcr_scan_srn = "  ";
            /// <summary>지능형순번기기일련번호</summary>
            ingn_sqn_mctl_srn = 0;
            /// <summary>텔러번호</summary>
            tln = "FS042403";
            /// <summary>계정갱신모드구분코드</summary>
            acit_rnl_mode_dcd = "1";
            /// <summary>마감전후구분코드</summary>
            bacl_dcd = "1";
            /// <summary>기산년월일</summary>
            rckn_ymd = "        ";
            /// <summary>유통무통구분코드</summary>
            ynbk_dcd = " ";
            /// <summary>현금대체구분코드</summary>
            caal_dcd = " ";
            /// <summary>출력용서비스ID</summary>
            prus_svc_id = "            ";
            /// <summary>출력용인터페이스ID</summary>
            prus_intf_id = "            ";
            /// <summary>통장일련번호</summary>
            bnkb_srn = 0;
            /// <summary>스마트조회일련번호</summary>
            smat_inq_srn = 0;
            /// <summary>IC칩매체종류구분코드</summary>
            ic_chip_mdia_kind_dcd = "N";
            /// <summary>부점코드</summary>
            brcd = "0885";
            /// <summary>조작자직원번호</summary>
            opto_emn = "0";
            /// <summary>책임자승인구분코드</summary>
            svat_dcd = "0";
            /// <summary>조작자승인구분코드</summary>
            opat_dcd = "0";
            /// <summary>전달메시지승인구분코드</summary>
            trmg_athz_dcd = "0";
            /// <summary>원화현금잔액</summary>
            won_cash_bal = -99999999999999;
            /// <summary>타점수납금액</summary>
            obrc_amt = -99999999999999;
            /// <summary>원화대체차액금액</summary>
            won_altr_dfam_amt = -99999999999999;
            /// <summary>외화대체불일치여부</summary>
            frctf_dscr_yn = "N";
        }

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

        public String DTST_LEN_STR { get { return dtst_len.ToString().PadLeft(6, '0'); } }

        /// <summary>단말설치부점코드</summary>
        private String trmn_inlt_brcd;

        /// <summary>단말설치부점코드(길이:4, 오프셋:8)</summary>
        public String TRMN_INLT_BRCD
        {
            get { return trmn_inlt_brcd.PadLeft(4, '0'); }
            set
            {
                trmn_inlt_brcd = value;
            }
        }

        /// <summary>단말번호</summary>
        private String tmn;

        /// <summary>단말번호(길이:3, 오프셋:12)</summary>
        public String TMN
        {
            get { return tmn.PadLeft(3, '0'); }
            set
            {
                tmn = value;
            }
        }

        /// <summary>신분증스캔일련번호</summary>
        private String idcr_scan_srn;

        /// <summary>신분증스캔일련번호(길이:2, 오프셋:15)</summary>
        public String IDCR_SCAN_SRN
        {
            get { return idcr_scan_srn.PadLeft(2, ' '); }
            set
            {
                idcr_scan_srn = value;
            }
        }

        /// <summary>지능형순번기기일련번호</summary>
        private Int32 ingn_sqn_mctl_srn;

        /// <summary>지능형순번기기일련번호(길이:4, 오프셋:17)</summary>
        public Int32 INGN_SQN_MCTL_SRN
        {
            get { return ingn_sqn_mctl_srn; }
            set
            {
                ingn_sqn_mctl_srn = value;
            }
        }

        public String INGN_SQN_MCTL_SRN_STR { get { return ingn_sqn_mctl_srn.ToString().PadLeft(4, '0'); } }

        /// <summary>텔러번호</summary>
        private String tln;

        /// <summary>텔러번호(길이:8, 오프셋:21)</summary>
        public String TLN
        {
            get { return tln.PadLeft(8, ' '); }
            set
            {
                tln = value;
            }
        }

        /// <summary>계정갱신모드구분코드</summary>
        private String acit_rnl_mode_dcd;

        /// <summary>계정갱신모드구분코드(길이:1, 오프셋:29)</summary>
        public String ACIT_RNL_MODE_DCD
        {
            get { return acit_rnl_mode_dcd; }
            set
            {
                acit_rnl_mode_dcd = value;
            }
        }

        /// <summary>마감전후구분코드</summary>
        private String bacl_dcd;

        /// <summary>마감전후구분코드(길이:1, 오프셋:30)</summary>
        public String BACL_DCD
        {
            get { return bacl_dcd; }
            set
            {
                bacl_dcd = value;
            }
        }

        /// <summary>기산년월일</summary>
        private String rckn_ymd;

        /// <summary>기산년월일(길이:8, 오프셋:31)</summary>
        public String RCKN_YMD
        {
            get { return rckn_ymd.PadLeft(8, '0'); }
            set
            {
                rckn_ymd = value;
            }
        }

        /// <summary>유통무통구분코드</summary>
        private String ynbk_dcd;

        /// <summary>유통무통구분코드(길이:1, 오프셋:39)</summary>
        public String YNBK_DCD
        {
            get { return ynbk_dcd; }
            set
            {
                ynbk_dcd = value;
            }
        }

        /// <summary>현금대체구분코드</summary>
        private String caal_dcd;

        /// <summary>현금대체구분코드(길이:1, 오프셋:40)</summary>
        public String CAAL_DCD
        {
            get { return caal_dcd; }
            set
            {
                caal_dcd = value;
            }
        }

        /// <summary>출력용서비스ID</summary>
        private String prus_svc_id;

        /// <summary>출력용서비스ID(길이:12, 오프셋:41)</summary>
        public String PRUS_SVC_ID
        {
            get { return prus_svc_id.PadLeft(12, ' '); }
            set
            {
                prus_svc_id = value;
            }
        }

        /// <summary>출력용인터페이스ID</summary>
        private String prus_intf_id;

        /// <summary>출력용인터페이스ID(길이:12, 오프셋:53)</summary>
        public String PRUS_INTF_ID
        {
            get { return prus_intf_id.PadLeft(12, ' '); }
            set
            {
                prus_intf_id = value;
            }
        }

        /// <summary>통장일련번호</summary>
        private Int32 bnkb_srn;

        /// <summary>통장일련번호(길이:5, 오프셋:65)</summary>
        public Int32 BNKB_SRN
        {
            get { return bnkb_srn; }
            set
            {
                bnkb_srn = value;
            }
        }

        public String BNKB_SRN_STR { get { return BNKB_SRN.ToString().PadLeft(5, '0'); } }

        /// <summary>스마트조회일련번호</summary>
        private Int32 smat_inq_srn;

        /// <summary>스마트조회일련번호(길이:2, 오프셋:70)</summary>
        public Int32 SMAT_INQ_SRN
        {
            get { return smat_inq_srn; }
            set
            {
                smat_inq_srn = value;
            }
        }

        public String SMAT_INQ_SRN_STR { get { return SMAT_INQ_SRN.ToString().PadLeft(2, '0'); } }

        /// <summary>IC칩매체종류구분코드</summary>
        private String ic_chip_mdia_kind_dcd;

        /// <summary>IC칩매체종류구분코드(길이:1, 오프셋:72)</summary>
        public String IC_CHIP_MDIA_KIND_DCD
        {
            get { return ic_chip_mdia_kind_dcd; }
            set
            {
                ic_chip_mdia_kind_dcd = value;
            }
        }

        /// <summary>부점코드</summary>
        private String brcd;

        /// <summary>부점코드(길이:4, 오프셋:73)</summary>
        public String BRCD
        {
            get { return brcd.PadLeft(4, '0'); }
            set
            {
                brcd = value;
            }
        }

        /// <summary>조작자직원번호</summary>
        private String opto_emn;

        /// <summary>조작자직원번호(길이:6, 오프셋:77)</summary>
        public String OPTO_EMN
        {
            get { return opto_emn.PadLeft(6, '0'); }
            set
            {
                opto_emn = value;
            }
        }

        /// <summary>책임자승인구분코드</summary>
        private String svat_dcd;

        /// <summary>책임자승인구분코드(길이:1, 오프셋:83)</summary>
        public String SVAT_DCD
        {
            get { return svat_dcd; }
            set
            {
                svat_dcd = value;
            }
        }

        /// <summary>조작자승인구분코드</summary>
        private String opat_dcd;

        /// <summary>조작자승인구분코드(길이:1, 오프셋:84)</summary>
        public String OPAT_DCD
        {
            get { return opat_dcd; }
            set
            {
                opat_dcd = value;
            }
        }

        /// <summary>전달메시지승인구분코드</summary>
        private String trmg_athz_dcd;

        /// <summary>전달메시지승인구분코드(길이:1, 오프셋:85)</summary>
        public String TRMG_ATHZ_DCD
        {
            get { return trmg_athz_dcd; }
            set
            {
                trmg_athz_dcd = value;
            }
        }

        /// <summary>원화현금잔액</summary>
        private long won_cash_bal;

        /// <summary>원화현금잔액(길이:15, 오프셋:86)</summary>
        public long WON_CASH_BAL
        {
            get { return won_cash_bal; }
            set
            {
                won_cash_bal = value;
            }
        }

        public String WON_CASH_BAL_STR { get { return WON_CASH_BAL.ToString().PadLeft(15, '0'); } }

        /// <summary>타점수납금액</summary>
        private long obrc_amt;

        /// <summary>타점수납금액(길이:15, 오프셋:101)</summary>
        public long OBRC_AMT
        {
            get { return obrc_amt; }
            set
            {
                obrc_amt = value;
            }
        }

        public String OBRC_AMT_STR { get { return OBRC_AMT.ToString().PadLeft(15, '0'); } }

        /// <summary>원화대체차액금액</summary>
        private long won_altr_dfam_amt;

        /// <summary>원화대체차액금액(길이:15, 오프셋:116)</summary>
        public long WON_ALTR_DFAM_AMT
        {
            get { return won_altr_dfam_amt; }
            set
            {
                won_altr_dfam_amt = value;
            }
        }

        public String WON_ALTR_DFAM_AMT_STR { get { return WON_ALTR_DFAM_AMT.ToString().PadLeft(15, '0'); } }

        /// <summary>외화대체불일치여부</summary>
        private String frctf_dscr_yn;

        /// <summary>외화대체불일치여부(길이:1, 오프셋:131)</summary>
        public String FRCTF_DSCR_YN
        {
            get { return frctf_dscr_yn; }
            set
            {
                frctf_dscr_yn = value;
            }
        }

        /// <summary>패킷 헤더 전문</summary>
        public String GetPacket()
        {
            var _packetStr =
                TRMN_INLT_BRCD
                + TMN
                + IDCR_SCAN_SRN
                + INGN_SQN_MCTL_SRN_STR
                + TLN
                + ACIT_RNL_MODE_DCD
                + BACL_DCD
                + RCKN_YMD
                + YNBK_DCD
                + CAAL_DCD
                + PRUS_SVC_ID
                + PRUS_INTF_ID
                + BNKB_SRN_STR
                + SMAT_INQ_SRN_STR
                + IC_CHIP_MDIA_KIND_DCD
                + BRCD
                + OPTO_EMN
                + SVAT_DCD
                + OPAT_DCD
                + TRMG_ATHZ_DCD
                + WON_CASH_BAL_STR
                + OBRC_AMT_STR
                + WON_ALTR_DFAM_AMT_STR
                + FRCTF_DSCR_YN;

            dtst_len = _packetStr.Length;

            return DTST_DCD + DTST_LEN_STR + _packetStr;
        }

    }
}

