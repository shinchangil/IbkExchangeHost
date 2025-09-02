using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class ibkEAIPacketRequest3
    {
        public ibkEAIPacketRequest3()
        {
            /// <summary>데이터셋구분코드</summary>
            dtst_dcd = "NC";
            /// <summary>데이터셋길이</summary>
            dtst_len = 000597;
            /// <summary>이용자식별번호</summary>
            usr_idnt_no = " ";
            /// <summary>하위이용자번호</summary>
            lrrn_usr_no = " ";
            /// <summary>전자금융고객ID</summary>
            ebk_cus_id = " ";
            /// <summary>이용자접속기기IP</summary>
            usr_cctn_mctl_ip = " ";
            /// <summary>이용자접속MAC값</summary>
            usr_cctn_mac_vl = " ";
            /// <summary>이용자접속전화번호</summary>
            usr_cctn_tpn = " ";
            /// <summary>이용자접속기기ID</summary>
            usr_cctn_mctl_id = " ";
            /// <summary>이용자계좌카드번호</summary>
            usr_acnt_cdn = " ";
            /// <summary>공인인증서고유식별번호</summary>
            atct_cqrcg_no = " ";
            /// <summary>비밀번호검증구분코드</summary>
            pwd_vrfc_dcd = " ";
            /// <summary>비밀번호암호화여부</summary>
            pwd_encp_yn = " ";
            /// <summary>보안매체구분코드</summary>
            secu_mdia_dcd = " ";
            /// <summary>보안매체번호</summary>
            secu_mdia_no = " ";
            /// <summary>보안카드순번1</summary>
            sccd_sqn1 = " ";
            /// <summary>보안카드비밀번호1</summary>
            sccd_pwd1 = " ";
            /// <summary>보안카드순번2</summary>
            sccd_sqn2 = " ";
            /// <summary>보안카드비밀번호2</summary>
            sccd_pwd2 = " ";
            /// <summary>이체비밀번호</summary>
            tran_pwd = " ";
            /// <summary>계좌비밀번호</summary>
            acnt_pwd = " ";
            /// <summary>OTP검증메시지코드</summary>
            otp_vrfc_msgcd = " ";
            /// <summary>서버출력요청건수</summary>
            srvr_otpt_rqst_nbi = 0;
            /// <summary>전문메시지코드</summary>
            tlgr_msgcd = " ";
            /// <summary>업체구분코드</summary>
            entp_dcd = " ";
            /// <summary>서버데이터전달부내용</summary>
            srvr_data_dlpr_con = " ";

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

        public String DTST_LEN_STR { get { return DTST_LEN.ToString().PadLeft(6, '0'); } }

        /// <summary>이용자식별번호</summary>
        private String usr_idnt_no;

        /// <summary>이용자식별번호(길이:13, 오프셋:8)</summary>
        public String USR_IDNT_NO
        {
            get { return usr_idnt_no.PadLeft(13, ' '); }
            set
            {
                usr_idnt_no = value;
            }
        }

        /// <summary>하위이용자번호</summary>
        private String lrrn_usr_no;

        /// <summary>하위이용자번호(길이:13, 오프셋:21)</summary>
        public String LRRN_USR_NO
        {
            get { return lrrn_usr_no.PadLeft(13, ' '); }
            set
            {
                lrrn_usr_no = value;
            }
        }

        /// <summary>전자금융고객ID</summary>
        private String ebk_cus_id;

        /// <summary>전자금융고객ID(길이:20, 오프셋:34)</summary>
        public String EBK_CUS_ID
        {
            get { return ebk_cus_id.PadLeft(20, ' '); }
            set
            {
                ebk_cus_id = value;
            }
        }

        /// <summary>이용자접속기기IP</summary>
        private String usr_cctn_mctl_ip;

        /// <summary>이용자접속기기IP(길이:39, 오프셋:54)</summary>
        public String USR_CCTN_MCTL_IP
        {
            get { return usr_cctn_mctl_ip.PadLeft(39, ' '); }
            set
            {
                usr_cctn_mctl_ip = value;
            }
        }

        /// <summary>이용자접속MAC값</summary>
        private String usr_cctn_mac_vl;

        /// <summary>이용자접속MAC값(길이:17, 오프셋:93)</summary>
        public String USR_CCTN_MAC_VL
        {
            get { return usr_cctn_mac_vl.PadLeft(17, ' '); }
            set
            {
                usr_cctn_mac_vl = value;
            }
        }

        /// <summary>이용자접속전화번호</summary>
        private String usr_cctn_tpn;

        /// <summary>이용자접속전화번호(길이:20, 오프셋:110)</summary>
        public String USR_CCTN_TPN
        {
            get { return usr_cctn_tpn.PadLeft(20, ' '); }
            set
            {
                usr_cctn_tpn = value;
            }
        }

        /// <summary>이용자접속기기ID</summary>
        private String usr_cctn_mctl_id;

        /// <summary>이용자접속기기ID(길이:20, 오프셋:130)</summary>
        public String USR_CCTN_MCTL_ID
        {
            get { return usr_cctn_mctl_id.PadLeft(20, ' '); }
            set
            {
                usr_cctn_mctl_id = value;
            }
        }

        /// <summary>이용자계좌카드번호</summary>
        private String usr_acnt_cdn;

        /// <summary>이용자계좌카드번호(길이:16, 오프셋:150)</summary>
        public String USR_ACNT_CDN
        {
            get { return usr_acnt_cdn.PadLeft(16, ' '); }
            set
            {
                usr_acnt_cdn = value;
            }
        }

        /// <summary>공인인증서고유식별번호</summary>
        private String atct_cqrcg_no;

        /// <summary>공인인증서고유식별번호(길이:25, 오프셋:166)</summary>
        public String ATCT_CQRCG_NO
        {
            get { return atct_cqrcg_no.PadLeft(25, ' '); }
            set
            {
                atct_cqrcg_no = value;
            }
        }

        /// <summary>비밀번호검증구분코드</summary>
        private String pwd_vrfc_dcd;

        /// <summary>비밀번호검증구분코드(길이:1, 오프셋:191)</summary>
        public String PWD_VRFC_DCD
        {
            get { return pwd_vrfc_dcd; }
            set
            {
                pwd_vrfc_dcd = value;
            }
        }

        /// <summary>비밀번호암호화여부</summary>
        private String pwd_encp_yn;

        /// <summary>비밀번호암호화여부(길이:1, 오프셋:192)</summary>
        public String PWD_ENCP_YN
        {
            get { return pwd_encp_yn; }
            set
            {
                pwd_encp_yn = value;
            }
        }

        /// <summary>보안매체구분코드</summary>
        private String secu_mdia_dcd;

        /// <summary>보안매체구분코드(길이:1, 오프셋:193)</summary>
        public String SECU_MDIA_DCD
        {
            get { return secu_mdia_dcd; }
            set
            {
                secu_mdia_dcd = value;
            }
        }

        /// <summary>보안매체번호</summary>
        private String secu_mdia_no;

        /// <summary>보안매체번호(길이:12, 오프셋:194)</summary>
        public String SECU_MDIA_NO
        {
            get { return secu_mdia_no.PadLeft(12, ' '); }
            set
            {
                secu_mdia_no = value;
            }
        }

        /// <summary>보안카드순번1</summary>
        private String sccd_sqn1;

        /// <summary>보안카드순번1(길이:3, 오프셋:206)</summary>
        public String SCCD_SQN1
        {
            get { return sccd_sqn1.PadLeft(3, ' '); }
            set
            {
                sccd_sqn1 = value;
            }
        }

        /// <summary>보안카드비밀번호1</summary>
        private String sccd_pwd1;

        /// <summary>보안카드비밀번호1(길이:4, 오프셋:209)</summary>
        public String SCCD_PWD1
        {
            get { return sccd_pwd1.PadLeft(4, ' '); }
            set
            {
                sccd_pwd1 = value;
            }
        }

        /// <summary>보안카드순번2</summary>
        private String sccd_sqn2;

        /// <summary>보안카드순번2(길이:3, 오프셋:213)</summary>
        public String SCCD_SQN2
        {
            get { return sccd_sqn2.PadLeft(3, ' '); }
            set
            {
                sccd_sqn2 = value;
            }
        }

        /// <summary>보안카드비밀번호2</summary>
        private String sccd_pwd2;

        /// <summary>보안카드비밀번호2(길이:4, 오프셋:216)</summary>
        public String SCCD_PWD2
        {
            get { return sccd_pwd2.PadLeft(4, ' '); }
            set
            {
                sccd_pwd2 = value;
            }
        }

        /// <summary>이체비밀번호</summary>
        private String tran_pwd;

        /// <summary>이체비밀번호(길이:128, 오프셋:220)</summary>
        public String TRAN_PWD
        {
            get { return tran_pwd.PadLeft(128, ' '); }
            set
            {
                tran_pwd = value;
            }
        }

        /// <summary>계좌비밀번호</summary>
        private String acnt_pwd;

        /// <summary>계좌비밀번호(길이:128, 오프셋:348)</summary>
        public String ACNT_PWD
        {
            get { return acnt_pwd.PadLeft(128, ' '); }
            set
            {
                acnt_pwd = value;
            }
        }

        /// <summary>OTP검증메시지코드</summary>
        private String otp_vrfc_msgcd;

        /// <summary>OTP검증메시지코드(길이:12, 오프셋:476)</summary>
        public String OTP_VRFC_MSGCD
        {
            get { return otp_vrfc_msgcd.PadLeft(12, ' '); }
            set
            {
                otp_vrfc_msgcd = value;
            }
        }

        /// <summary>서버출력요청건수</summary>
        private Int32 srvr_otpt_rqst_nbi;

        /// <summary>서버출력요청건수(길이:5, 오프셋:488)</summary>
        public Int32 SRVR_OTPT_RQST_NBI
        {
            get { return srvr_otpt_rqst_nbi; }
            set
            {
                srvr_otpt_rqst_nbi = value;
            }
        }

        public String SRVR_OTPT_RQST_NBI_STR { get { return SRVR_OTPT_RQST_NBI.ToString().PadLeft(5, '0'); } }

        /// <summary>전문메시지코드</summary>
        private String tlgr_msgcd;

        /// <summary>전문메시지코드(길이:7, 오프셋:493)</summary>
        public String TLGR_MSGCD
        {
            get { return tlgr_msgcd.PadLeft(7, ' '); }
            set
            {
                tlgr_msgcd = value;
            }
        }

        /// <summary>업체구분코드</summary>
        private String entp_dcd;

        /// <summary>업체구분코드(길이:5, 오프셋:500)</summary>
        public String ENTP_DCD
        {
            get { return entp_dcd.PadLeft(5, ' '); }
            set
            {
                entp_dcd = value;
            }
        }

        /// <summary>서버데이터전달부내용</summary>
        private String srvr_data_dlpr_con;

        /// <summary>서버데이터전달부내용(길이:100, 오프셋:505)</summary>
        public String SRVR_DATA_DLPR_CON
        {
            get { return srvr_data_dlpr_con.PadLeft(100, ' '); }
            set
            {
                srvr_data_dlpr_con = value;
            }
        }

        /// <summary>패킷 헤더 전문</summary>
        public String GetPacket()
        {
            var _packetStr =
                USR_IDNT_NO
                + LRRN_USR_NO
                + EBK_CUS_ID
                + USR_CCTN_MCTL_IP
                + USR_CCTN_MAC_VL
                + USR_CCTN_TPN
                + USR_CCTN_MCTL_ID
                + USR_ACNT_CDN
                + ATCT_CQRCG_NO
                + PWD_VRFC_DCD
                + PWD_ENCP_YN
                + SECU_MDIA_DCD
                + SECU_MDIA_NO
                + SCCD_SQN1
                + SCCD_PWD1
                + SCCD_SQN2
                + SCCD_PWD2
                + TRAN_PWD
                + ACNT_PWD
                + OTP_VRFC_MSGCD
                + SRVR_OTPT_RQST_NBI_STR
                + TLGR_MSGCD
                + ENTP_DCD
                + SRVR_DATA_DLPR_CON;

            dtst_len = _packetStr.Length;

            return DTST_DCD + DTST_LEN_STR + _packetStr;
            
        }
    }
}
