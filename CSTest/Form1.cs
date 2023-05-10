using System;
using System.Text;
using System.Windows.Forms;

using SimpleMC;


namespace CSTest
{

   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public SimpleMC.SimpleMC ComInit(SimpleMC.SimpleMC ins)
        {

   


            ins.ActHostAddress = "192.168.1.10";
            ins.ActPortNumber = 2000;

            //列挙体はサンプルプロジェクトの Enum.csに定義しています。
            ins.BinaryASCII = (EnumBinaryASCII.Binary != 0); //Binary に設定
            ins.MCProtocol = (byte)EnumMCProtocol.フレーム4E;  // Ethernet(3E,4E)のﾊﾞｲﾅﾘ, 形式5(4Cﾌﾚｰﾑﾊﾞｲﾅﾘ)に対応しています。
            ins.TIMEOUT = 100; // 100×10msec に設定

            return ins;

        }





        private void ReadDeviceRandom2_Click(object sender, EventArgs e)
        {
            SimpleMC.SimpleMC ins = new SimpleMC.SimpleMC();


            SimpleMC.SimpleMC.RetrunRandomWORD insRandomRec = new SimpleMC.SimpleMC.RetrunRandomWORD();
            ins = ComInit(ins);
            insRandomRec = ins.ReadDeviceRandom2("D0", "D100", "D200");
            MessageBox.Show(insRandomRec.Finished.ToString());

            while (!insRandomRec.Finished) { }

            MessageBox.Show(insRandomRec.Finished.ToString());

            if (insRandomRec.DataOK) { MessageBox.Show(insRandomRec.UShortArray[2].ToString()); }
            else { MessageBox.Show("Write Fault"); }


        }

        private void WriteDeviceRandom2_Click(object sender, EventArgs e)
        {

            SimpleMC.SimpleMC ins = new SimpleMC.SimpleMC();


            SimpleMC.SimpleMC.ReturnBasic insWriteRec = new SimpleMC.SimpleMC.ReturnBasic();  //Write系の戻り型は Bsic である。
            ins = ComInit(ins);
            insWriteRec = ins.ReadDeviceRandom2(3, "D0", 100, "D100", 200, "D200", 333);
            MessageBox.Show(insWriteRec.Finished.ToString());

            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }



            object[,] obj = new object[3, 2];
            obj[0, 0] = "D0"; obj[0, 1] = 33;
            obj[1, 0] = "D100"; obj[1, 1] = 55;
            obj[2, 0] = "D200"; obj[2, 1] = 77;

            //2次元オブジェクト配列を渡す場合
            insWriteRec = ins.WriteDeviceRandom2(3, obj);

            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }



        }

        private void WriteDeviceRandom2ArrayBIT_Click(object sender, EventArgs e)
        {
            SimpleMC.SimpleMC ins = new SimpleMC.SimpleMC();


            SimpleMC.SimpleMC.ReturnBasic insWriteRec = new SimpleMC.SimpleMC.ReturnBasic();
            ins = ComInit(ins);
            insWriteRec = ins.WriteDeviceRandom2ArrayBIT(3, "M0", 1, "M100", 0, "M200", 1);
            MessageBox.Show(insWriteRec.Finished.ToString());

            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }


            //可変引数でデバイス・書込みデータを指定する場合

            object[,] obj = new object[3, 2];
            obj[0, 0] = "M0"; obj[0, 1] = 1;
            obj[1, 0] = "M100"; obj[1, 1] = 0;
            obj[2, 0] = "M200"; obj[2, 1] = 1;

            //2次元オブジェクト配列を渡す場合
            insWriteRec = ins.WriteDeviceRandom2(3, obj);


            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }



        }

        private void WriteDeviceRandom2DWord_Click(object sender, EventArgs e)
        {
            SimpleMC.SimpleMC ins = new SimpleMC.SimpleMC();


            SimpleMC.SimpleMC.ReturnBasic insWriteRec = new SimpleMC.SimpleMC.ReturnBasic();

            //可変引数でデバイス・書込みデータを指定する場合
            insWriteRec = ins.WriteDeviceRandom2DWord(3, "D1", 0x12345678, "D3", 0x87654321, "D5", 0x54364975);

            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }


            object[,] obj = new object[3, 2];
            obj[0, 0] = "D1"; obj[0, 1] = 0x12345678;
            obj[1, 0] = "D3"; obj[1, 1] = 0x87654321;
            obj[2, 0] = "D5"; obj[2, 1] = 0x54364975;

            //2次元オブジェクト配列を渡す場合
            insWriteRec = ins.WriteDeviceRandom2(3, obj);

            while (!insWriteRec.Finished) { }

            MessageBox.Show(insWriteRec.Finished.ToString());

            if (insWriteRec.DataOK) { MessageBox.Show("Write Success"); }
            else { MessageBox.Show("Write Fault"); }





        }
    }

}