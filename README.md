# simplemc
If you want to create a C# or VB.NET application that communicates via Ethernet or RS-232C between a PC and a MELSEC PLC Q, 
the MC protocol communication library “Simple MC” may be an alternative to MX Component. Simple GX is a communication library 
provided by Mitsubishi that allows communication between a PC and a MELSEC PLC Q without using MX Component.


## 内容物
- "SimpleMC.dll" (要 .NET4.5互換 Runtime.  .NET DLL)
- Sample Application Project


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
