using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAIPacketRequest1
    {
        NLog.Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>전문1 기본 생성자</summary>
        /// <param name="requestSeq">요청 발생 순번 </param>
        /// <param name="myIPAddress">발신 시스템 IP 주소</param>
        /// <param name="myMacAddress">발신 시스템 MAC 주소</param>
        /// <param name="targetIPAddress">EAI 시스템 IP 주소</param>
        /// <param name="targetPort">EAI 시스템 PORT 주소</param>
        public ibkEAIPacketRequest1(Int32 requestSeq, String myIPAddress, String myMacAddress, String targetIPAddress, Int32 targetPort)
        {
            var _reqTime = DateTime.Now.Subtract(TimeSpan.FromDays(5)).ToString("yyyyMMddHHmmssfff");


            /// <summary>표준전문길이</summary>
            sttl_len = 001579;
            /// <summary>표준전문압축여부</summary>
            sttl_cmrs_yn = "Y";
            /// <summary>표준전문암호화구분코드</summary>
            sttl_encp_dcd = "1";
            /// <summary>표준전문언어구분코드</summary>
            sttl_lngg_dcd = "KO";
            /// <summary>표준전문버전구분값</summary>
            sttl_ver_dsnc = "024";
            /// <summary>전행표준전문작성년월일</summary>
            whbn_sttl_wrtn_ymd = _reqTime.Substring(0, 8);
            /// <summary>전행표준전문생성시스템명</summary>
            whbn_sttl_cret_sys_nm = "NFB00000";
            /// <summary>전행표준전문일련번호</summary>
            whbn_sttl_srn = "28006716000003";
            /// <summary>전행표준전문진행구분번호</summary>
            whbn_sttl_pgrs_dsnc_no = 0;
            /// <summary>전행표준전문진행번호</summary>
            whbn_sttl_pgrs_no = 1;
            /// <summary>표준전문인터페이스UNIQUEID</summary>
            sttl_intf_anun_id = $"{_reqTime.Substring(0,8)}NFB{requestSeq.ToString().PadLeft(6, '0')}{_reqTime}";
            /// <summary>표준전문IP</summary>
            sttl_ip = myIPAddress;
            /// <summary>표준전문MAC주소값</summary>
            sttl_mac_adr_vl = myMacAddress;
            /// <summary>시스템환경정보구분코드</summary>
            sys_envr_info_dcd = "P";
            /// <summary>최초요청일시</summary>
            frst_rqst_ts = _reqTime;
            /// <summary>표준전문유지시간사용여부</summary>
            sttl_mctm_use_yn = "N";
            /// <summary>표준전문유지시간초값</summary>
            sttl_mctm_sec_vl = 0;
            /// <summary>송신시스템구분코드</summary>
            trnm_sys_dcd = "NFB";
            /// <summary>송신노드ID</summary>
            trnm_nd_id = "0";
            /// <summary>송신일시</summary>
            trnm_ts = _reqTime;
            /// <summary>요청응답구분코드</summary>
            rqst_rspn_dcd = "S";
            /// <summary>표준전문개별부버전일련번호</summary>
            sttl_idpr_vrsn_srn = 25;
            /// <summary>요청시스템구분코드</summary>
            rqst_sys_dcd = "NFB";
            /// <summary>요청시스템업무구분코드</summary>
            rqst_sys_bswr_dcd = "NFB";
            /// <summary>표준전문인터페이스ID</summary>
            sttl_intf_id = "NFBO00083530";
            /// <summary>동기응답대기구분코드</summary>
            sync_rspn_wait_dcd = "S";
            /// <summary>XA거래여부</summary>
            etah_trn_yn = "N";
            /// <summary>입력전문유형구분코드</summary>
            inpt_tmgt_dcd = "0";
            /// <summary>표준전문요청일시</summary>
            sttl_rqst_ts = _reqTime;
            /// <summary>요청수신서비스ID</summary>
            rqst_rcv_svc_id = "NFBO00000000";
            /// <summary>응답수신서비스ID</summary>
            rspn_rcv_svc_id = "            ";
            /// <summary>오류응답서비스ID</summary>
            eror_rspn_svc_id = "            ";
            /// <summary>응답수신노드ID</summary>
            rspn_rcv_nd_id = "        ";
            /// <summary>비드응답수신노드IP </summary>
            bid_rspn_rcv_nd_ip = targetIPAddress;
            /// <summary>비드응답수신포트번호</summary>
            bid_rspn_rcv_port_no = targetPort;
            /// <summary>인터페이스노드ID</summary>
            intf_nd_id = "dmca0101";
            /// <summary>응답시스템구분코드</summary>
            rspn_sys_dcd = "   ";
            /// <summary>표준전문응답일시</summary>
            sttl_rspn_ts = "                 ";
            /// <summary>응답처리결과구분코드</summary>
            rspn_pcrs_dcd = " ";
            /// <summary>출력전문유형구분코드</summary>
            otpt_tmgt_dcd = " ";
            /// <summary>오류발생시스템구분코드</summary>
            eroc_sys_dcd = "   ";
            /// <summary>표준전문오류코드</summary>
            sttl_ercd = "            ";
            /// <summary>요청채널유형구분코드</summary>
            rqst_chpt_dcd = "NFB";
            /// <summary>요청채널유형세부구분코드</summary>
            rqst_chpt_dtls_dcd = "NFB";
            /// <summary>요청채널업무구분코드</summary>
            rqst_chbs_dcd = "NFB";
            /// <summary>요청채널세션ID</summary>
            rqst_chnl_ssn_id = " ";
            /// <summary>SSO사용여부</summary>
            sso_use_yn = "N";
            /// <summary>대량입출력거래글로벌ID</summary>
            lrqn_inop_trn_glbl_id = $"{_reqTime.Substring(0, 8)}NFBO000835300000{requestSeq.ToString().PadLeft(6, '0')}";
            /// <summary>대량입출력연속번호</summary>
            lrqn_inop_ctnt_no = 00;
            /// <summary>시스템공통부예비필드</summary>
            sys_copt_flop = "                      ";
            /// <summary>거래채널구분코드</summary>
            trn_chnl_dcd = "OLT";
            /// <summary>거래요청업무구분코드</summary>
            trrq_bswr_dcd = "NFB";
            /// <summary>표준전문거래코드</summary>
            sttl_xcd = "NFBO00000000";
            /// <summary>표준전문요청기능구분ID</summary>
            sttl_rqst_func_dsnc_id = "800";
            /// <summary>표준전문응답기능구분ID</summary>
            sttl_rspn_func_dsnc_id = " ";
            /// <summary>표준전문오류기능구분ID</summary>
            sttl_eror_func_dsnc_id = " ";
            /// <summary>입력화면번호</summary>
            inpt_scre_no = "0";
            /// <summary>선조회거래여부</summary>
            ahd_iqtr_yn = "N";
            /// <summary>취소구분코드</summary>
            cncl_dcd = "1";
            /// <summary>연속거래구분코드</summary>
            ctnt_trn_dcd = "0";
            /// <summary>입력거래일련번호 </summary>
            inpt_trn_srn = 1;
            /// <summary>소속금융회사코드</summary>
            blng_fncm_cd = "1";
            /// <summary>접촉정보거래종류코드</summary>
            tcsl_info_trn_kcd = 0;
            /// <summary>대외거래업무구분코드</summary>
            ext_trn_bswr_dcd = "    ";
            /// <summary>대외거래기관구분코드</summary>
            ext_trn_intt_dcd = "    ";
            /// <summary>대외거래고유ID</summary>
            ext_trn_unq_id = "                                                ";
            /// <summary>대외연계인터페이스ID</summary>
            ext_lnk_intf_id = "                                                   ";
            /// <summary>대외거래세션ID</summary>
            ext_trn_ssn_id = "                              ";
            /// <summary>대외거래라우팅ID</summary>
            ext_trn_rutn_id = "     ";
            /// <summary>거래공통부예비필드</summary>
            trn_copt_flop = "                                                  ";

        }

        /// <summary>표준전문길이</summary>
        private Int32 sttl_len;

        /// <summary>표준전문길이(길이:6, 오프셋:0)</summary>
        public Int32 STTL_LEN
        {
            get { return sttl_len; }
            set
            {
                sttl_len = value;
            }
        }

        /// <summary>표준전문길이</summary>
        public String STTL_LEN_STR { get { return sttl_len.ToString().PadLeft(6, '0'); } }

        /// <summary>표준전문압축여부</summary>
        private String sttl_cmrs_yn;

        /// <summary>표준전문압축여부(길이:1, 오프셋:6)</summary>
        public String STTL_CMRS_YN
        {
            get { return sttl_cmrs_yn; }
            set
            {
                sttl_cmrs_yn = value;
            }
        }

        /// <summary>표준전문암호화구분코드</summary>
        private String sttl_encp_dcd;

        /// <summary>표준전문암호화구분코드(길이:1, 오프셋:7)</summary>
        public String STTL_ENCP_DCD
        {
            get { return sttl_encp_dcd; }
            set
            {
                sttl_encp_dcd = value;
            }
        }

        /// <summary>표준전문언어구분코드</summary>
        private String sttl_lngg_dcd;

        /// <summary>표준전문언어구분코드(길이:2, 오프셋:8)</summary>
        public String STTL_LNGG_DCD
        {
            get { return sttl_lngg_dcd.PadLeft(2, '0'); }
            set
            {
                sttl_lngg_dcd = value;
            }
        }

        /// <summary>표준전문버전구분값</summary>
        private String sttl_ver_dsnc;

        /// <summary>표준전문버전구분값(길이:3, 오프셋:10)</summary>
        public String STTL_VER_DSNC
        {
            get { return sttl_ver_dsnc.PadLeft(3, '0'); }
            set
            {
                sttl_ver_dsnc = value;
            }
        }

        /// <summary>전행표준전문작성년월일</summary>
        private String whbn_sttl_wrtn_ymd;

        /// <summary>전행표준전문작성년월일(길이:8, 오프셋:13)</summary>
        public String WHBN_STTL_WRTN_YMD
        {
            get { return whbn_sttl_wrtn_ymd.PadLeft(8, '0'); }
            set
            {
                whbn_sttl_wrtn_ymd = value;
            }
        }

        /// <summary>전행표준전문생성시스템명</summary>
        private String whbn_sttl_cret_sys_nm;

        /// <summary>전행표준전문생성시스템명(길이:8, 오프셋:21)</summary>
        public String WHBN_STTL_CRET_SYS_NM
        {
            get { return whbn_sttl_cret_sys_nm.PadLeft(8, '0'); }
            set
            {
                whbn_sttl_cret_sys_nm = value;
            }
        }

        /// <summary>전행표준전문일련번호</summary>
        private String whbn_sttl_srn;

        /// <summary>전행표준전문일련번호(길이:14, 오프셋:29)</summary>
        public String WHBN_STTL_SRN
        {
            get { return whbn_sttl_srn.PadLeft(14, '0'); }
            set
            {
                whbn_sttl_srn = value;
            }
        }

        /// <summary>전행표준전문진행구분번호</summary>
        private Int32 whbn_sttl_pgrs_dsnc_no;

        /// <summary>전행표준전문진행구분번호(길이:4, 오프셋:43)</summary>
        public Int32 WHBN_STTL_PGRS_DSNC_NO
        {
            get { return whbn_sttl_pgrs_dsnc_no; }
            set
            {
                whbn_sttl_pgrs_dsnc_no = value;
            }
        }

        public String WHBN_STTL_PGRS_DSNC_NO_STR { get { return whbn_sttl_pgrs_dsnc_no.ToString().PadLeft(4, '0'); } }

        /// <summary>전행표준전문진행번호</summary>
        private Int32 whbn_sttl_pgrs_no;

        /// <summary>전행표준전문진행번호(길이:4, 오프셋:47)</summary>
        public Int32 WHBN_STTL_PGRS_NO
        {
            get { return whbn_sttl_pgrs_no; }
            set
            {
                whbn_sttl_pgrs_no = value;
            }
        }

        public String WHBN_STTL_PGRS_NO_STR { get { return whbn_sttl_pgrs_no.ToString().PadLeft(4, '0'); } }

        /// <summary>표준전문인터페이스UNIQUEID</summary>
        private String sttl_intf_anun_id;

        /// <summary>표준전문인터페이스UNIQUEID(길이:34, 오프셋:51)</summary>
        public String STTL_INTF_ANUN_ID
        {
            get { return sttl_intf_anun_id.PadLeft(34, '0'); }
            set
            {
                sttl_intf_anun_id = value;
            }
        }

        /// <summary>표준전문IP</summary>
        private String sttl_ip;

        /// <summary>표준전문IP(길이:39, 오프셋:85)</summary>
        public String STTL_IP
        {
            get { return sttl_ip.PadRight(39); }
            set
            {
                sttl_ip = value;
            }
        }

        /// <summary>표준전문MAC주소값</summary>
        private String sttl_mac_adr_vl;

        /// <summary>표준전문MAC주소값(길이:12, 오프셋:124)</summary>
        public String STTL_MAC_ADR_VL
        {
            get { return sttl_mac_adr_vl.PadLeft(12, '0'); }
            set
            {
                sttl_mac_adr_vl = value;
            }
        }

        /// <summary>시스템환경정보구분코드</summary>
        private String sys_envr_info_dcd;

        /// <summary>시스템환경정보구분코드(길이:1, 오프셋:136)</summary>
        public String SYS_ENVR_INFO_DCD
        {
            get { return sys_envr_info_dcd; }
            set
            {
                sys_envr_info_dcd = value;
            }
        }

        /// <summary>최초요청일시</summary>
        private String frst_rqst_ts;

        /// <summary>최초요청일시(길이:17, 오프셋:137)</summary>
        public String FRST_RQST_TS
        {
            get { return frst_rqst_ts.PadLeft(17, '0'); }
            set
            {
                frst_rqst_ts = value;
            }
        }

        /// <summary>표준전문유지시간사용여부</summary>
        private String sttl_mctm_use_yn;

        /// <summary>표준전문유지시간사용여부(길이:1, 오프셋:154)</summary>
        public String STTL_MCTM_USE_YN
        {
            get { return sttl_mctm_use_yn; }
            set
            {
                sttl_mctm_use_yn = value;
            }
        }

        /// <summary>표준전문유지시간초값</summary>
        private Int32 sttl_mctm_sec_vl;

        /// <summary>표준전문유지시간초값(길이:3, 오프셋:155)</summary>
        public Int32 STTL_MCTM_SEC_VL
        {
            get { return sttl_mctm_sec_vl; }
            set
            {
                sttl_mctm_sec_vl = value;
            }
        }

        /// <summary>표준전문유지시간초값(길이:3, 오프셋:155)</summary>
        public String STTL_MCTM_SEC_VL_STR { get { return sttl_mctm_sec_vl.ToString().PadLeft(3, '0'); } }

        /// <summary>송신시스템구분코드</summary>
        private String trnm_sys_dcd;

        /// <summary>송신시스템구분코드(길이:3, 오프셋:158)</summary>
        public String TRNM_SYS_DCD
        {
            get { return trnm_sys_dcd.PadLeft(3, '0'); }
            set
            {
                trnm_sys_dcd = value;
            }
        }

        /// <summary>송신노드ID</summary>
        private String trnm_nd_id;

        /// <summary>송신노드ID(길이:8, 오프셋:161)</summary>
        public String TRNM_ND_ID
        {
            get { return trnm_nd_id.PadLeft(8, '0'); }
            set
            {
                trnm_nd_id = value;
            }
        }

        /// <summary>송신일시</summary>
        private String trnm_ts;

        /// <summary>송신일시(길이:17, 오프셋:169)</summary>
        public String TRNM_TS
        {
            get { return trnm_ts.PadLeft(17, '0'); }
            set
            {
                trnm_ts = value;
            }
        }

        /// <summary>요청응답구분코드</summary>
        private String rqst_rspn_dcd;

        /// <summary>요청응답구분코드(길이:1, 오프셋:186)</summary>
        public String RQST_RSPN_DCD
        {
            get { return rqst_rspn_dcd; }
            set
            {
                rqst_rspn_dcd = value;
            }
        }

        /// <summary>표준전문개별부버전일련번호</summary>
        private Int32 sttl_idpr_vrsn_srn;

        /// <summary>표준전문개별부버전일련번호(길이:5, 오프셋:187)</summary>
        public Int32 STTL_IDPR_VRSN_SRN
        {
            get { return sttl_idpr_vrsn_srn; }
            set
            {
                sttl_idpr_vrsn_srn = value;
            }
        }

        /// <summary>표준전문개별부버전일련번호(길이:5, 오프셋:187)</summary>
        public String STTL_IDPR_VRSN_SRN_STR { get { return sttl_idpr_vrsn_srn.ToString().PadLeft(5, '0'); } }

        /// <summary>요청시스템구분코드</summary>
        private String rqst_sys_dcd;

        /// <summary>요청시스템구분코드(길이:3, 오프셋:192)</summary>
        public String RQST_SYS_DCD
        {
            get { return rqst_sys_dcd.PadLeft(3, '0'); }
            set
            {
                rqst_sys_dcd = value;
            }
        }

        /// <summary>요청시스템업무구분코드</summary>
        private String rqst_sys_bswr_dcd;

        /// <summary>요청시스템업무구분코드(길이:3, 오프셋:195)</summary>
        public String RQST_SYS_BSWR_DCD
        {
            get { return rqst_sys_bswr_dcd.PadLeft(3, '0'); }
            set
            {
                rqst_sys_bswr_dcd = value;
            }
        }

        /// <summary>표준전문인터페이스ID</summary>
        private String sttl_intf_id;

        /// <summary>표준전문인터페이스ID(길이:12, 오프셋:198)</summary>
        public String STTL_INTF_ID
        {
            get { return sttl_intf_id.PadLeft(12, '0'); }
            set
            {
                sttl_intf_id = value;
            }
        }

        /// <summary>동기응답대기구분코드</summary>
        private String sync_rspn_wait_dcd;

        /// <summary>동기응답대기구분코드(길이:1, 오프셋:210)</summary>
        public String SYNC_RSPN_WAIT_DCD
        {
            get { return sync_rspn_wait_dcd; }
            set
            {
                sync_rspn_wait_dcd = value;
            }
        }

        /// <summary>XA거래여부</summary>
        private String etah_trn_yn;

        /// <summary>XA거래여부(길이:1, 오프셋:211)</summary>
        public String ETAH_TRN_YN
        {
            get { return etah_trn_yn; }
            set
            {
                etah_trn_yn = value;
            }
        }

        /// <summary>입력전문유형구분코드</summary>
        private String inpt_tmgt_dcd;

        /// <summary>입력전문유형구분코드(길이:1, 오프셋:212)</summary>
        public String INPT_TMGT_DCD
        {
            get { return inpt_tmgt_dcd; }
            set
            {
                inpt_tmgt_dcd = value;
            }
        }

        /// <summary>표준전문요청일시</summary>
        private String sttl_rqst_ts;

        /// <summary>표준전문요청일시(길이:17, 오프셋:213)</summary>
        public String STTL_RQST_TS
        {
            get { return sttl_rqst_ts.PadLeft(17, '0'); }
            set
            {
                sttl_rqst_ts = value;
            }
        }

        /// <summary>요청수신서비스ID</summary>
        private String rqst_rcv_svc_id;

        /// <summary>요청수신서비스ID(길이:12, 오프셋:230)</summary>
        public String RQST_RCV_SVC_ID
        {
            get { return rqst_rcv_svc_id.PadLeft(12, '0'); }
            set
            {
                rqst_rcv_svc_id = value;
            }
        }

        /// <summary>응답수신서비스ID</summary>
        private String rspn_rcv_svc_id;

        /// <summary>응답수신서비스ID(길이:12, 오프셋:242)</summary>
        public String RSPN_RCV_SVC_ID
        {
            get { return rspn_rcv_svc_id.PadLeft(12, '0'); }
            set
            {
                rspn_rcv_svc_id = value;
            }
        }

        /// <summary>오류응답서비스ID</summary>
        private String eror_rspn_svc_id;

        /// <summary>오류응답서비스ID(길이:12, 오프셋:254)</summary>
        public String EROR_RSPN_SVC_ID
        {
            get { return eror_rspn_svc_id.PadLeft(12, '0'); }
            set
            {
                eror_rspn_svc_id = value;
            }
        }

        /// <summary>응답수신노드ID</summary>
        private String rspn_rcv_nd_id;

        /// <summary>응답수신노드ID(길이:8, 오프셋:266)</summary>
        public String RSPN_RCV_ND_ID
        {
            get { return rspn_rcv_nd_id.PadLeft(8, ' '); }
            set
            {
                rspn_rcv_nd_id = value;
            }
        }

        /// <summary>비드응답수신노드IP </summary>
        private String bid_rspn_rcv_nd_ip;

        /// <summary>비드응답수신노드IP (길이:39, 오프셋:274)</summary>
        public String BID_RSPN_RCV_ND_IP
        {
            get { return bid_rspn_rcv_nd_ip.PadRight(39); }
            set
            {
                bid_rspn_rcv_nd_ip = value;
            }
        }

        /// <summary>비드응답수신포트번호</summary>
        private Int32 bid_rspn_rcv_port_no;

        /// <summary>비드응답수신포트번호(길이:5, 오프셋:313)</summary>
        public Int32 BID_RSPN_RCV_PORT_NO
        {
            get { return bid_rspn_rcv_port_no; }
            set
            {
                bid_rspn_rcv_port_no = value;
            }
        }

        public String BID_RSPN_RCV_PORT_NO_STR { get { return bid_rspn_rcv_port_no.ToString().PadLeft(5, '0'); } }


        /// <summary>인터페이스노드ID</summary>
        private String intf_nd_id;

        /// <summary>인터페이스노드ID(길이:8, 오프셋:318)</summary>
        public String INTF_ND_ID
        {
            get { return intf_nd_id.PadLeft(8, '0'); }
            set
            {
                intf_nd_id = value;
            }
        }

        /// <summary>응답시스템구분코드</summary>
        private String rspn_sys_dcd;

        /// <summary>응답시스템구분코드(길이:3, 오프셋:326)</summary>
        public String RSPN_SYS_DCD
        {
            get { return rspn_sys_dcd.PadLeft(3, ' '); }
            set
            {
                rspn_sys_dcd = value;
            }
        }

        /// <summary>표준전문응답일시</summary>
        private String sttl_rspn_ts;

        /// <summary>표준전문응답일시(길이:17, 오프셋:329)</summary>
        public String STTL_RSPN_TS
        {
            get { return sttl_rspn_ts.PadLeft(17, ' '); }
            set
            {
                sttl_rspn_ts = value;
            }
        }

        /// <summary>응답처리결과구분코드</summary>
        private String rspn_pcrs_dcd;

        /// <summary>응답처리결과구분코드(길이:1, 오프셋:346)</summary>
        public String RSPN_PCRS_DCD
        {
            get { return rspn_pcrs_dcd.PadLeft(1, ' '); }
            set
            {
                rspn_pcrs_dcd = value;
            }
        }

        /// <summary>출력전문유형구분코드</summary>
        private String otpt_tmgt_dcd;

        /// <summary>출력전문유형구분코드(길이:1, 오프셋:347)</summary>
        public String OTPT_TMGT_DCD
        {
            get { return otpt_tmgt_dcd.PadLeft(1, ' '); }
            set
            {
                otpt_tmgt_dcd = value;
            }
        }

        /// <summary>오류발생시스템구분코드</summary>
        private String eroc_sys_dcd;

        /// <summary>오류발생시스템구분코드(길이:3, 오프셋:348)</summary>
        public String EROC_SYS_DCD
        {
            get { return eroc_sys_dcd.PadLeft(3, ' '); }
            set
            {
                eroc_sys_dcd = value;
            }
        }

        /// <summary>표준전문오류코드</summary>
        private String sttl_ercd;

        /// <summary>표준전문오류코드(길이:12, 오프셋:351)</summary>
        public String STTL_ERCD
        {
            get { return sttl_ercd.PadLeft(12, ' '); }
            set
            {
                sttl_ercd = value;
            }
        }

        /// <summary>요청채널유형구분코드</summary>
        private String rqst_chpt_dcd;

        /// <summary>요청채널유형구분코드(길이:3, 오프셋:363)</summary>
        public String RQST_CHPT_DCD
        {
            get { return rqst_chpt_dcd.PadLeft(3, '0'); }
            set
            {
                rqst_chpt_dcd = value;
            }
        }

        /// <summary>요청채널유형세부구분코드</summary>
        private String rqst_chpt_dtls_dcd;

        /// <summary>요청채널유형세부구분코드(길이:3, 오프셋:366)</summary>
        public String RQST_CHPT_DTLS_DCD
        {
            get { return rqst_chpt_dtls_dcd.PadLeft(3, '0'); }
            set
            {
                rqst_chpt_dtls_dcd = value;
            }
        }

        /// <summary>요청채널업무구분코드</summary>
        private String rqst_chbs_dcd;

        /// <summary>요청채널업무구분코드(길이:3, 오프셋:369)</summary>
        public String RQST_CHBS_DCD
        {
            get { return rqst_chbs_dcd.PadLeft(3, '0'); }
            set
            {
                rqst_chbs_dcd = value;
            }
        }

        /// <summary>요청채널세션ID</summary>
        private String rqst_chnl_ssn_id;

        /// <summary>요청채널세션ID(길이:23, 오프셋:372)</summary>
        public String RQST_CHNL_SSN_ID
        {
            get { return rqst_chnl_ssn_id.PadLeft(23, '0'); }
            set
            {
                rqst_chnl_ssn_id = value;
            }
        }

        /// <summary>SSO사용여부</summary>
        private String sso_use_yn;

        /// <summary>SSO사용여부(길이:1, 오프셋:395)</summary>
        public String SSO_USE_YN
        {
            get { return sso_use_yn; }
            set
            {
                sso_use_yn = value;
            }
        }

        /// <summary>대량입출력거래글로벌ID</summary>
        private String lrqn_inop_trn_glbl_id;

        /// <summary>대량입출력거래글로벌ID(길이:30, 오프셋:396)</summary>
        public String LRQN_INOP_TRN_GLBL_ID
        {
            get { return lrqn_inop_trn_glbl_id.PadLeft(30, '0'); }
            set
            {
                lrqn_inop_trn_glbl_id = value;
            }
        }

        /// <summary>대량입출력연속번호</summary>
        private Int32 lrqn_inop_ctnt_no;

        /// <summary>대량입출력연속번호(길이:2, 오프셋:426)</summary>
        public Int32 LRQN_INOP_CTNT_NO
        {
            get { return lrqn_inop_ctnt_no; }
            set
            {
                lrqn_inop_ctnt_no = value;
            }
        }

        public String LRQN_INOP_CTNT_NO_STR { get { return lrqn_inop_ctnt_no.ToString().PadLeft(2, '0'); } }

        /// <summary>시스템공통부예비필드</summary>
        private String sys_copt_flop;

        /// <summary>시스템공통부예비필드(길이:22, 오프셋:428)</summary>
        public String SYS_COPT_FLOP
        {
            get { return sys_copt_flop.PadLeft(22, ' '); }
            set
            {
                sys_copt_flop = value;
            }
        }

        /// <summary>거래채널구분코드</summary>
        private String trn_chnl_dcd;

        /// <summary>거래채널구분코드(길이:3, 오프셋:0)</summary>
        public String TRN_CHNL_DCD
        {
            get { return trn_chnl_dcd.PadLeft(3, '0'); }
            set
            {
                trn_chnl_dcd = value;
            }
        }

        /// <summary>거래요청업무구분코드</summary>
        private String trrq_bswr_dcd;

        /// <summary>거래요청업무구분코드(길이:3, 오프셋:3)</summary>
        public String TRRQ_BSWR_DCD
        {
            get { return trrq_bswr_dcd.PadLeft(3, '0'); }
            set
            {
                trrq_bswr_dcd = value;
            }
        }

        /// <summary>표준전문거래코드</summary>
        private String sttl_xcd;

        /// <summary>표준전문거래코드(길이:15, 오프셋:6)</summary>
        public String STTL_XCD
        {
            get { return sttl_xcd.PadLeft(15, ' '); }
            set
            {
                sttl_xcd = value;
            }
        }

        /// <summary>표준전문요청기능구분ID</summary>
        private String sttl_rqst_func_dsnc_id;

        /// <summary>표준전문요청기능구분ID(길이:3, 오프셋:21)</summary>
        public String STTL_RQST_FUNC_DSNC_ID
        {
            get { return sttl_rqst_func_dsnc_id.PadLeft(3, '0'); }
            set
            {
                sttl_rqst_func_dsnc_id = value;
            }
        }

        /// <summary>표준전문응답기능구분ID</summary>
        private String sttl_rspn_func_dsnc_id;

        /// <summary>표준전문응답기능구분ID(길이:3, 오프셋:24)</summary>
        public String STTL_RSPN_FUNC_DSNC_ID
        {
            get { return sttl_rspn_func_dsnc_id.PadLeft(3, ' '); }
            set
            {
                sttl_rspn_func_dsnc_id = value;
            }
        }

        /// <summary>표준전문오류기능구분ID</summary>
        private String sttl_eror_func_dsnc_id;

        /// <summary>표준전문오류기능구분ID(길이:3, 오프셋:27)</summary>
        public String STTL_EROR_FUNC_DSNC_ID
        {
            get { return sttl_eror_func_dsnc_id.PadLeft(3, ' '); }
            set
            {
                sttl_eror_func_dsnc_id = value;
            }
        }

        /// <summary>입력화면번호</summary>
        private String inpt_scre_no;

        /// <summary>입력화면번호(길이:9, 오프셋:30)</summary>
        public String INPT_SCRE_NO
        {
            get { return inpt_scre_no.PadLeft(9, '0'); }
            set
            {
                inpt_scre_no = value;
            }
        }

        /// <summary>선조회거래여부</summary>
        private String ahd_iqtr_yn;

        /// <summary>선조회거래여부(길이:1, 오프셋:39)</summary>
        public String AHD_IQTR_YN
        {
            get { return ahd_iqtr_yn; }
            set
            {
                ahd_iqtr_yn = value;
            }
        }

        /// <summary>취소구분코드</summary>
        private String cncl_dcd;

        /// <summary>취소구분코드(길이:1, 오프셋:40)</summary>
        public String CNCL_DCD
        {
            get { return cncl_dcd; }
            set
            {
                cncl_dcd = value;
            }
        }

        /// <summary>연속거래구분코드</summary>
        private String ctnt_trn_dcd;

        /// <summary>연속거래구분코드(길이:1, 오프셋:41)</summary>
        public String CTNT_TRN_DCD
        {
            get { return ctnt_trn_dcd; }
            set
            {
                ctnt_trn_dcd = value;
            }
        }

        /// <summary>입력거래일련번호 </summary>
        private Int32 inpt_trn_srn;

        /// <summary>입력거래일련번호 (길이:10, 오프셋:42)</summary>
        public Int32 INPT_TRN_SRN
        {
            get { return inpt_trn_srn; }
            set
            {
                inpt_trn_srn = value;
            }
        }
        
        /// <summary>입력거래일련번호 (길이:10, 오프셋:42)</summary>
        public String INPT_TRN_SRN_STR { get { return inpt_trn_srn.ToString().PadLeft(10, '0'); } }

        /// <summary>소속금융회사코드</summary>
        private String blng_fncm_cd;

        /// <summary>소속금융회사코드(길이:3, 오프셋:52)</summary>
        public String BLNG_FNCM_CD
        {
            get { return blng_fncm_cd.PadLeft(3, '0'); }
            set
            {
                blng_fncm_cd = value;
            }
        }

        /// <summary>접촉정보거래종류코드</summary>
        private Int32 tcsl_info_trn_kcd;

        /// <summary>접촉정보거래종류코드(길이:3, 오프셋:55)</summary>
        public Int32 TCSL_INFO_TRN_KCD
        {
            get { return tcsl_info_trn_kcd; }
            set
            {
                tcsl_info_trn_kcd = value;
            }
        }

        public String TCSL_INFO_TRN_KCD_STR { get { return tcsl_info_trn_kcd.ToString().PadLeft(3, '0'); } }


        /// <summary>대외거래업무구분코드</summary>
        private String ext_trn_bswr_dcd;

        /// <summary>대외거래업무구분코드(길이:4, 오프셋:58)</summary>
        public String EXT_TRN_BSWR_DCD
        {
            get { return ext_trn_bswr_dcd.PadLeft(4, ' '); }
            set
            {
                ext_trn_bswr_dcd = value;
            }
        }

        /// <summary>대외거래기관구분코드</summary>
        private String ext_trn_intt_dcd;

        /// <summary>대외거래기관구분코드(길이:4, 오프셋:62)</summary>
        public String EXT_TRN_INTT_DCD
        {
            get { return ext_trn_intt_dcd.PadLeft(4, ' '); }
            set
            {
                ext_trn_intt_dcd = value;
            }
        }

        /// <summary>대외거래고유ID</summary>
        private String ext_trn_unq_id;

        /// <summary>대외거래고유ID(길이:48, 오프셋:66)</summary>
        public String EXT_TRN_UNQ_ID
        {
            get { return ext_trn_unq_id.PadLeft(48, ' '); }
            set
            {
                ext_trn_unq_id = value;
            }
        }

        /// <summary>대외연계인터페이스ID</summary>
        private String ext_lnk_intf_id;

        /// <summary>대외연계인터페이스ID(길이:51, 오프셋:114)</summary>
        public String EXT_LNK_INTF_ID
        {
            get { return ext_lnk_intf_id.PadLeft(51, ' '); }
            set
            {
                ext_lnk_intf_id = value;
            }
        }

        /// <summary>대외거래세션ID</summary>
        private String ext_trn_ssn_id;

        /// <summary>대외거래세션ID(길이:30, 오프셋:165)</summary>
        public String EXT_TRN_SSN_ID
        {
            get { return ext_trn_ssn_id.PadLeft(30, ' '); }
            set
            {
                ext_trn_ssn_id = value;
            }
        }

        /// <summary>대외거래라우팅ID</summary>
        private String ext_trn_rutn_id;

        /// <summary>대외거래라우팅ID(길이:5, 오프셋:195)</summary>
        public String EXT_TRN_RUTN_ID
        {
            get { return ext_trn_rutn_id.PadLeft(5, ' '); }
            set
            {
                ext_trn_rutn_id = value;
            }
        }

        /// <summary>거래공통부예비필드</summary>
        private String trn_copt_flop;

        /// <summary>거래공통부예비필드(길이:50, 오프셋:200)</summary>
        public String TRN_COPT_FLOP
        {
            get { return trn_copt_flop.PadLeft(50, ' '); }
            set
            {
                trn_copt_flop = value;
            }
        }

        /// <summary>패킷 헤더 전문</summary>
        /// <param name="isHost">계정계/</param>
        public String GetPacket(Boolean isHost,String packet)
        {
            var _ip = STTL_IP;

            if (isHost == true)
            {
                sttl_intf_id = "NFBO00084444";
                rqst_rcv_svc_id = "CBKFEX508012";
                sttl_xcd = "CBKFEX508012"+ STTL_RQST_FUNC_DSNC_ID;
            }
            else
            {
                sttl_intf_id = "NFBO00083530";
            }

            var _packetStr =
                STTL_CMRS_YN
                + STTL_ENCP_DCD
                + STTL_LNGG_DCD
                + STTL_VER_DSNC
                + WHBN_STTL_WRTN_YMD
                + WHBN_STTL_CRET_SYS_NM
                + WHBN_STTL_SRN
                + WHBN_STTL_PGRS_DSNC_NO_STR
                + WHBN_STTL_PGRS_NO_STR
                + STTL_INTF_ANUN_ID
                + STTL_IP
                + STTL_MAC_ADR_VL
                + SYS_ENVR_INFO_DCD
                + FRST_RQST_TS
                + STTL_MCTM_USE_YN
                + STTL_MCTM_SEC_VL_STR
                + TRNM_SYS_DCD
                + TRNM_ND_ID
                + TRNM_TS
                + RQST_RSPN_DCD
                + STTL_IDPR_VRSN_SRN_STR
                + RQST_SYS_DCD
                + RQST_SYS_BSWR_DCD
                + STTL_INTF_ID
                + SYNC_RSPN_WAIT_DCD
                + ETAH_TRN_YN
                + INPT_TMGT_DCD
                + STTL_RQST_TS
                + RQST_RCV_SVC_ID
                + RSPN_RCV_SVC_ID
                + EROR_RSPN_SVC_ID
                + RSPN_RCV_ND_ID
                + BID_RSPN_RCV_ND_IP
                + BID_RSPN_RCV_PORT_NO_STR
                + INTF_ND_ID
                + RSPN_SYS_DCD
                + STTL_RSPN_TS
                + RSPN_PCRS_DCD
                + OTPT_TMGT_DCD
                + EROC_SYS_DCD
                + STTL_ERCD
                + RQST_CHPT_DCD
                + RQST_CHPT_DTLS_DCD
                + RQST_CHBS_DCD
                + RQST_CHNL_SSN_ID
                + SSO_USE_YN
                + LRQN_INOP_TRN_GLBL_ID
                + LRQN_INOP_CTNT_NO_STR
                + SYS_COPT_FLOP
                + TRN_CHNL_DCD
                + TRRQ_BSWR_DCD
                + STTL_XCD
                + STTL_RQST_FUNC_DSNC_ID
                + STTL_RSPN_FUNC_DSNC_ID
                + STTL_EROR_FUNC_DSNC_ID
                + INPT_SCRE_NO
                + AHD_IQTR_YN
                + CNCL_DCD
                + CTNT_TRN_DCD
                + INPT_TRN_SRN_STR
                + BLNG_FNCM_CD
                + TCSL_INFO_TRN_KCD_STR
                + EXT_TRN_BSWR_DCD
                + EXT_TRN_INTT_DCD
                + EXT_TRN_UNQ_ID
                + EXT_LNK_INTF_ID
                + EXT_TRN_SSN_ID
                + EXT_TRN_RUTN_ID
                + TRN_COPT_FLOP;

            sttl_len = _packetStr.Length + packet.Length;

            return STTL_LEN_STR + _packetStr + packet;
        }
    }
}
