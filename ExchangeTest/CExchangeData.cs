using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTest
{
    public class CExchangeData
    {
        public string? BASE_DD { get; set; }
        public string? NOTI_TURN_CNT { get; set; }
        public string? CUR { get; set; }
        public string? CUR_QUOT_ODR { get; set; }
        public double? US_EXCH_RT { get; set; }
        public double? DL_BAS_RT { get; set; }
        public double? CRS_RT { get; set; }
        public double? BOOK_PRC_BAS_RT { get; set; }
        public double? TT_BUY_RT { get; set; }
        public double? TT_SELL_RT { get; set; }
        public double? CASH_BUY_RT { get; set; }
        public double? CASH_SELL_RT { get; set; }
        public double? TC_SELL_RT { get; set; }
        public double? COIN_BUY_RT { get; set; }
        public double? COIN_SELL_RT { get; set; }
        public double? SGT_DMD_DFT_BID_RT { get; set; }
        public string? CREAT_DD { get; set; }
        public string? CREAT_TIME { get; set; }
        public string? CREAT_USER_ID { get; set; }
    }
    public class CExchangeData20240703
    {
        public string? BASE_DD { get; set; } //기준 날짜
        public string? NOTI_TURN_CNT { get; set; } //회차
        public string? CUR { get; set; } //이름
        public double? DL_BAS_RT { get; set; } //1400 매매기준율        
        public double? CASH_BUY_RT { get; set; } //팔때
        public double? CASH_SELL_RT { get; set; }//살때
        public string? CREAT_DD { get; set; } //등록 일자
        public string? CREAT_TIME { get; set; } //등록 시각
        public double? UP_DOWN_RT { get; set; } = 0.0;
    }

    public class CExchangeData20240807
    {
        public string? BASE_DD { get; set; } //기준 날짜
        public string? NOTI_TURN_CNT { get; set; } //회차
        public string? CUR { get; set; } //이름
        public string? DL_BAS_RT { get; set; } //매매기준율 
        public string? US_EXCH_RT { get; set; }
        public string? TT_BUY_RT { get; set; }
        public string? TT_SELL_RT { get; set; }
        public string? CASH_BUY_RT { get; set; } //팔때
        public string? CASH_SELL_RT { get; set; }//살때
    }

    public class CExchage20240807
    {
        public List<CExchangeData20240807> exchList { get; set; }
    }
    

    public class CExchList
    {
        public List<CExchangeData20240712> exch { get; set; }
        public Cgraph graph { get; set; }
        public List<CGraphMaxMin> graphMaxMin { get; set; }
    }

    public class CGraphMaxMin
    {
        public int RNUM { get; set; }
        public string CUR { get; set; }
        public string DL_BAS_RT { get; set; }
        public string UPDATEDT { get; set; }
        public string VTYPE { get; set; }
    }

    public class Cgraph
    {
        public List<CgraphData> USD { get; set; }
        public List<CgraphData> JPY { get; set; }
        public List<CgraphData> EUR { get; set; }
        public List<CgraphData> CNY { get; set; }
    }
    public class CgraphData
    {
        public double? DL_BAS_RT { get; set; }
        public string? UPDATEDT { get; set; }
    }

    public class CExchangeData20240712
    {
        public string? BASE_DD { get; set; } //기준 날짜
        public string? NOTI_TURN_CNT { get; set; } //회차
        public string? CUR { get; set; } //이름
        public double? DL_BAS_RT { get; set; } //1400 매매기준율        
        public double? CASH_BUY_RT { get; set; } //팔때
        public double? CASH_SELL_RT { get; set; }//살때
        public double? TT_BUY_RT { get; set; }
        public double? TT_SELL_RT { get; set; }
        public string? COMPARE { get; set; }
        public string? COMPARED_PRG { get; set; }
    }

    public class CExEndValue
    {
        public string BASE_DD { get; set; }
        public string NOTI_TURN_CNT { get; set; }
        public string CUR { get; set; }
        public double? DL_BAS_RT { get; set; }
    }

    public class CExEndValueList
    {
        public List<CExEndValue> exchList { get; set; }
    }
}
