using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTest
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;






        #region "Enum応答種別"

        ///<summary>
        /// 通信結果のステータスに関する列挙体です。
        ///</summary>
        public enum Enum応答 : byte
        {

            ///<summary>
            /// 正常なデータが返ってきたときのステータスです。
            ///</summary>
            正常あり = 1,

            ///<summary>
            /// 通信自体は成功しているがデータがないときのステータスです。
            ///</summary>
            正常なし = 2,

            ///<summary>
            /// 通信自体は成功しているが機器異常があるときのステータスです。このときはErrorCodeプロパティ参照によりエラー情報をえられます。
            ///</summary>
            異常終了 = 3,

            ///<summary>
            /// 通信自体が失敗したときのステータスです。このときのデータは利用しないでください。
            ///</summary>
            通信不可 = 10,
        }
        #endregion


        #region "列挙体二重化マルチCPU種別"

        ///<summary>
        /// 二重化マルチCPU種別の設定候補(列挙体)です。通信対象がマルチCPUである場合設定してください。通信パラメタを直接設定しない場合、設定が必要です。
        ///</summary>
        public enum Enum二重化マルチCPU種別 : byte
        {

            ///<summary>
            /// CPUがマルチCPUで管理CPUに設定されているときはこれを設定してください
            ///</summary>
            マルチ管理CPU = 10,

            ///<summary>
            /// CPUがマルチCPUで1号機CPUに設定されているときはこれを設定してください
            ///</summary>
            マルチ1号機CPU = 11,

            ///<summary>
            /// CPUがマルチCPUで2号機CPUに設定されているときはこれを設定してください
            ///</summary>
            マルチ2号機CPU = 12,

            ///<summary>
            /// CPUがマルチCPUで3号機CPUに設定されているときはこれを設定してください
            ///</summary>
            マルチ3号機CPU = 13,

            ///<summary>
            /// CPUがマルチCPUで4号機CPUに設定されているときはこれを設定してください
            ///</summary>
            マルチ4号機CPU = 14,

            ///<summary>
            /// CPUが二重化CPUで制御系CPUに設定されているときはこれを設定してください
            ///</summary>
            二重化CPU制御系 = 21,

            ///<summary>
            /// CPUが二重化CPUで待機系CPUに設定されているときはこれを設定してください
            ///</summary>
            二重化CPU待機系 = 22,

            ///<summary>
            /// CPUが二重化CPUでA系CPUに設定されているときはこれを設定してください
            ///</summary>
            二重化CPUA系 = 23,

            ///<summary>
            /// CPUが二重化CPUでB系CPUに設定されているときはこれを設定してください
            ///</summary>
            二重化CPUB系 = 24,

            ///<summary>
            /// CC-Link IEが二重化で1号機に設定されているときはこれを設定してください
            ///</summary>
            二重化CCLinkIE1号機 = 25,


            ///<summary>
            /// CC-Link IEが二重化で2号機に設定されているときはこれを設定してください
            ///</summary>
            二重化CCLinkIE2号機 = 26,


            ///<summary>
            /// CC-Link IEが二重化で制御系に設定されているときはこれを設定してください
            ///</summary>
            二重化CCLinkIE制御系 = 27,


            ///<summary>
            /// CC-Link IEが二重化で待機系に設定されているときはこれを設定してください
            ///</summary>
            二重化CCLinkIE待機系 = 28,
        }
        #endregion


        #region "列挙体PLC構成"

        ///<summary>
        /// PLC構成プロパティの設定候補(列挙体)です。通信対象のPLCネットワーク構成を設定してください。通信パラメタを直接設定しない場合、設定が必要です。
        ///</summary>
        public enum EnumPLC構成 : byte
        {

            ///<summary>
            ///データ読書き対象がシングルCPUであり、そのCPUのスロットに装着された唯一の通信ユニットに
            ///外部機器（PCなど）と接続されている場合はPLC構成としてこれを設定します。
            ///</summary>
            シングルCPU単一ネットワーク内における = 1,

            ///<summary>
            ///データ読書き対象が二重化またはマルチCPUであり、そのCPUのスロットに装着された唯一の通信ユニットに
            ///外部機器（PCなど）と接続されている場合はPLC構成としてこれを設定します。
            ///</summary>
            二重化またはマルチCPU単一ネットワーク内における = 2,

            ///<summary>
            ///データ読書き対象がシングルCPUであり、そのCPUのスロットに装着された唯一の通信ユニットが
            ///RS232Cユニットであり、それとマルチドロップ接続で外部機器（PCなど）と接続する場合はこれを設定します。
            ///</summary>
            マルチドロップ接続単一ネットワーク内における = 3,

            ///<summary>
            ///中継局(CCLinkIE, MELSECNET)を介するネットワーク上の任意の管理局/マスタユニットが装着されているスロットの
            ///シングルCPUにアクセスする場合は、PLC構成としてこれを設定します。
            ///</summary>
            設定管理局ネットワーク中継をしている = 4,

            ///<summary>
            ///中継局(CCLinkIE, MELSECNET)を介するネットワーク上の実際に管理局として機能している管理局/マスタユニット
            ///が装着されているスロットのシングルCPUにアクセスする場合は、PLC構成としてこれを設定します。
            ///</summary>
            現在管理局ネットワーク中継をしている = 5,

            ///<summary>
            ///ネットワーク経由の通常局, またはEthernetユニットが装着されているスロットのシングルCPU、
            ///または１つのスロットに複数の通信ユニット(RS232C,MELSECNET,Ethernet,CC-LinkIE)がある場合には設定します。
            ///</summary>
            シングルCPU他ネットワークの = 6,

            ///<summary>
            ///ネットワーク経由の通常局, またはEthernetユニットが装着されているスロットにおけるRS232Cユニットと
            ///マルチドロップ接続しているRS232Cユニットが装着されているスロットにあるシングルCPUとアクセスしたい場合、
            ///または１つのスロットに複数の通信ユニット(RS232C,MELSECNET,Ethernet,CC-LinkIE)がある場合、その
            ///スロットのRS232Cユニットとマルチドロップ接続されているRS232Cユニットが装着されているスロットにある
            ///シングルCPUと接続する場合はこれを設定します。
            ///</summary>
            マルチドロップ接続他ネットワークの = 7,


        }
        #endregion


        #region "列挙体MCProtocol"

        ///<summary>
        /// MCProtocolプロパティの設定候補(列挙体)です。通信プロトコルを設定します。必ず設定してください。
        ///形式2-5に設定した場合はプロパティActComPort, ActDatabit, ActParity, ActStopbit,ActControl,ActSumcheck,ActBaudRateを必ず設定してください
        ///また, 形式2-4については, 任意でプロパティActFrame で通信フレームを選択することもできます。
        ///フレーム3E,4Eを選択した場合はプロパティActHostAddress, ActPortNumberを必ず設定してください。
        ///</summary>


        public enum EnumMCProtocol : byte
        {

            ///<summary>
            /// RS232C通信ユニットに形式5で通信する場合設定してください。
            ///</summary>
            形式5 = 5,

            ///<summary>
            /// RS232C通信ユニットに形式4で通信する場合設定してください。
            ///</summary>
            形式4 = 4,

            ///   <summary>
            /// RS232C通信ユニットに形式3で通信する場合設定してください。
            ///  </summary>
            形式3 = 3,

            ///<summary>
            /// RS232C通信ユニットに形式2で通信する場合設定してください。
            ///</summary>
            形式2 = 2,

            ///<summary>
            /// Ethernetユニットに4Eフレームで通信する場合設定してください。
            ///</summary>
            フレーム4E = 0x4E,

            ///<summary>
            /// Ethernetユニットに3Eフレームで通信する場合設定してください。
            ///</summary>
            フレーム3E = 0x3E,
        }
        #endregion

        #region "列挙体CFrame"

        ///<summary>
        ///CFrameプロパティの選択候補（列挙体）。RS232通信において任意に選択するフレームです。
        ///</summary>


        public enum EnumCFrame : byte
        {

            ///<summary>
            /// RS232C通信においてフレーム2Cで通信する場合設定してください(ただし形式5の場合選択不可)
            ///</summary>
            フレーム2C = 2,

            ///<summary>
            /// RS232C通信においてフレーム3Cで通信する場合設定してください(ただし形式5の場合選択不可)
            ///</summary>
            フレーム3C = 3,

            ///<summary>
            /// RS232C通信においてフレーム4Cで通信する場合設定してください。
            ///</summary>
            フレーム4C = 4,


        }
        #endregion

        #region "列挙体BinaryASCII"

        ///<summary>
        ///BinaryASCIIプロパティの選択候補（列挙体）。Etherまたはシリアルの形式5のときにASCIIかバイナリか選択します。
        ///</summary>
        public enum EnumBinaryASCII : byte
        {

            ///<summary>
            /// ASCIIでデータ送信する場合選択してください。
            ///</summary>
            ASCII = 0,

            ///<summary>
            /// バイナリでデータ送信する場合選択してください。
            ///</summary>
            Binary = 1,
        }
        #endregion


        #region "列挙体ActBaudRate"
        ///<summary>
        ///ActBaudRateプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumBaudRate : int
        {

            bps9600 = 9600,
            bps19200 = 19200,
            bps115200 = 115200,

        }
        #endregion


        #region "列挙体ActDatabits"
        ///<summary>
        ///ActDatabitsプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumDatabits : byte
        {
            bit7 = 7,
            bit8 = 8,
        }
        #endregion


        #region "列挙体ActStopbits"
        ///<summary>
        ///ActStopbitsプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumStopbits : byte
        {
            None = 0,
            One = 1,
            Two = 2,
            OnePointFive = 3,
        }
        #endregion

        #region "列挙体ActParity"
        ///<summary>
        ///ActParityプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumParity : byte
        {
            Noneなし = 0,
            Odd奇数 = 1,
            Even偶数 = 2,
            Mark常に1のパリティ = 3,
            Space常に0のパリティ = 4,
        }
        #endregion

        #region "列挙体EnumHandShake"
        ///<summary>
        ///HandShakeプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumHandShake : byte
        {
            None = 0,
            XonXoff = 1,
            RequestToSend_RTS = 2,
            RTS_and_XonXoff = 3,
        }
        #endregion


        #region "列挙体EnumQiQ"
        ///<summary>
        ///QiQプロパティの選択候補（列挙体）
        ///</summary>
        public enum EnumQiQ : byte
        {
            Q = 1,
            iQ = 2,
        }
        #endregion











    }










