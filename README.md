# Tida.CAD
Tida.CAD is a CAD framework built on .net platform,Which targets on highlt extensibility,MVVM,high performance.

This project consists of these parts:

1. Core parts (built on .Net Standard platform):

 	- Tida.Canvas.Contracts defines the basic concepts for a Canvas(ICanvasControl,DrawObject,CanvasLayer,EditTool...),input(Mouse and keyboard),media(Color ,Pen..).
 
 	- Tida.Canvas.Infrastructure provides the common codes(like LineBase,PointBase) that user codes might leverage.to make these codes platform-independent.
		
2. WPF part: 

 	- Tida.Canvas.WPFCanvas contains a WPF implementation for a ICanvasControl,this implementation is a the only one at present.
 
		
3. Example parts:

 	- Tida.Canvas.Base provides some useful basic tools(DrawObjects and EditTools),Tida.Canvas.Shell.Contracts defines the contract for the Example framework. 

 	- Tida.Canvas.Shell provides the main implementations of UI parts,(note:This project use the Progress Telerik UI controls for WPF Trail version), to make the framwork more extensible,these projects are build on Prism and MEF, Tida.Canvas.Launcher is the entry project,which refrence these parts as Modules.


		
		
![example](Images/Line.JPG)

