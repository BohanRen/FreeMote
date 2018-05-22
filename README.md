# FreeMote
Managed Emote tool libs.
## 组件
### FreeMote
基本功能，解密或者加密EmotePSB文件
>Basic functions. Decrypt or encrypt Emote PSB files.
### FreeMote [SDK](https://github.com/Project-AZUSA/FreeMote-SDK)
专门针对Emote引擎的API，一个可以加载 纯PSB(未加密)文件的引擎
>Special API libs for Emote engine, which take _pure_ (unencrypted) PSB files as input.
### FreeMote.Psb
转换PSB的格式，不用Emote引擎绘制一个Emote模型(静态的)
>Parse PSB format. Draw the Emote model (statically) without Emote engine.
### FreeMote.PsBuild
编译和反编译PSB文件，转换PSB文件在不同的平台
>Compile and decompile PSB files. Convert PSB among different platforms.
### FreeMote.Purify (Unreleased)
这个是获得dll的私匙源码，暂时没有开源，要获取源码请联系QQ:1551608379
>Infer and calculate the key used by Emote PSB file just from the PSB file (rather than get from engine).
### FreeMote.FreeLive (Unrealistic)
Emote和Live2D模型相互转换，理论上不可能，所以没开源
>Emote <-> Live2D Conversion

## 工具
### EmoteConv (FreeMote.Tools.EmotePsbConverter)
转换PSB文件
>Convert Emote PSB files. A managed version of `emote_conv`(by number201724).
### PsbDecompile (FreeMote.Tools.PsbDecompile)
反编译PSB文件
>Decompile PSB files. A managed version of `decompiler`(by number201724).
### PsBuild (FreeMote.Tools.PsBuild)
编译PSB文件
>Compile PSB description json to PSB. A managed version of `pcc`(by number201724).
<h2>以下为原作者版权:</h2>
### [FreeMoteViewer](https://github.com/Project-AZUSA/FreeMote.NET#freemoteviewer) (FreeMote.Tools.Viewer)
Open and render Emote _pure_ PSB.

---
by **Ulysses** (wdwxy12345@gmail.com) from Project AZUSA

FreeMote is licensed under **LGPL**.

[Issue Report](https://github.com/UlyssesWu/FreeMote/issues) · [Pull Request](https://github.com/UlyssesWu/FreeMote/pulls) · [Wiki](https://github.com/UlyssesWu/FreeMote/wiki)

[![Support Us](https://az743702.vo.msecnd.net/cdn/kofi2.png?v=0 "Buy Me a Coffee at ko-fi.com")](https://ko-fi.com/Ulysses)

## Thanks

* @9chu for reverse engineering help.
* @number201724 for PSB format.
* @nalsas (awatm) for Emote Editor help.
* @WcLyic (牧濑红莉栖) for some PSB samples and Emote Editor help.
* [MonoGame](https://github.com/MonoGame/MonoGame) for `DxtUtil` code. LICENSE: Ms-PL
* Singyuen Yip for `Adler32` code.
* @gdkchan for [DxtCodec](https://github.com/gdkchan/CEGTool/blob/master/CEGTool/DXTCodec.cs) code.
* @mfascia for [TexturePacker](https://github.com/mfascia/TexturePacker) code.
* @morkt for [ImageTLG](https://github.com/morkt/GARbro/blob/master/ArcFormats/KiriKiri/ImageTLG.cs) code. LICENSE: MIT
* All nuget references used in this project.
