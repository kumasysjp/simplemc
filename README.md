# simplemc
If you want to create a C# or VB.NET application that communicates via Ethernet or RS-232C between a PC and a MELSEC PLC Q, 
the MC protocol communication library “Simple MC” may be an alternative to MX Component. Simple GX is a communication library 
provided by Mitsubishi that allows communication between a PC and a MELSEC PLC Q without using MX Component.


## 内容物
- "SimpleMC.dll" (要 .NET4.5互換 Runtime.  .NET DLL)
- Sample Application Project

## 機能

-
Use “SimpleMC” | How to use C# on MELSEC Q PLC ?
.NET DLL to access MELSEC PLC. You can make communicate with one via the C#, VB.NET by using this.  Function e.g : WriteDeviceBlock2, ReadDeviceBlock2 ( Like MX Component)    

ダウンロード
 

マニュアル
 

( ver.1.0, 20230502 , zip ,   更新履歴)  

 

動作環境
【 動作 SDK 】Visual Studio 2013,  2019 【動作環境】 Windows 10 (64bit) 【必要な環境※】.NET 4.5.1 互換Runtime (.NET)  

 

機能( SimpleMC.dll)
三菱MELSEC PLC Q にVB.NET, C# でアクセスできる MCプロトコル通信ライブラリです。

- Ethernet(3E),  シリアルは RS-232C(形式2-5) の通信が可能
- Ethernet においてはバイナリ/ASCII 選択可 ( シリアルはプロトコル仕様上、固定）
- タイムアウト設定ができる
- ランダム読み書き、ビット単位読み書き、ダブルワード単位読み書きも可能 (※1)
- MELSECNET や シリアルユニットを介したネットワーク構成にも対応 (※2)
  
  
  ※1.  WriteDeviceBlock2, ReadDeviceBlock2,WriteDeviceBlock2DWord, ReadDeviceBlock2DWord,WriteDeviceBlock2BIT, ReadDeviceBlock2BIT,WriteDeviceBlock2ArrayBit, ReadDeviceBlock2ArrayBit,WriteDeviceRandom2, ReadDeviceRandom2,WriteRandomBlock2,の関数を実装 
  
  ※2. プロパティのうち, MX Component のそれに相当するのは, ActHostAddress,ActPortNumber,ActSourceUnitNumber,ActCOMPort,ActBaudRate,ActDatabits,ActStopbits,ActParity, ActDtrEnable,ActRtsEnable,ActHandShake,ActSourceStation,ActSourceUnitNumber,ActNetworkNumber,ActUnitNumber,ActIONumber,ActConnectUnitNumber,ActCPUTimeOut  

 

## 利用方法

zipをダウンロードし解凍します。DLL参照済みであるVisual Studio ソリューションファイルを VS2013-2022 で開きます。サンプルアプリを自由に変更し実行します。
添付ソリューションは VB.NET 向けです。DLL参照の設定は、ごく一般的方法です。


### CSharp
```cs
//using SimpleGXSimu でDLLを読み込んでください
//using SimpleMC; でインポート

　　　　　　 SimpleMC.SimpleMC ins = new SimpleMC.SimpleMC();
            SimpleMC.SimpleMC.RetrunRandomWORD insRandomRec = new SimpleMC.SimpleMC.RetrunRandomWORD();
            insRandomRec = ins.ReadDeviceRandom2("D0", "D100", "D200");
             
             while (!insRandomRec.Finished) { } //sync complete
           //use data  
```

### VB.NET
```vb
'Imports SimpleMC.SimpleMC でDLLを読み込んでください

        Dim a As New SimpleMC.SimpleMC
        Dim data(200) As UShort
        data(0) = &HABCD
        data(1) = &HFFFF

//nonsync
        a.WriteDeviceBlock2BIT("M100", data, 16) 

```
