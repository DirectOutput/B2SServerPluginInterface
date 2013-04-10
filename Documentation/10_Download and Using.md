Download and using the B2SServerPluginInterface.dll {#downloadusing}
===============================================

\section downloadusing_download Download B2SServerPluginInterface.dll

The B2SServerPluginInterface.dll can be downloaded as follows:

- Download from .............................
- The B2SServerPluginInterface.dll is also part of the deployment package of the B2S.Server.

\section downloadusing_downloadsource Download source code

The source code of the B2SServerPluginInterface.dll can be aquired from GitHub <a href="https://github.com/DirectOutput/B2SServerPluginInterface">https://github.com/DirectOutput/B2SServerPluginInterface</a>.

If you are planning to implement your own plugin, do <b>NOT</b> use a self compiled version of the interface dll. Download the binary version to avoid compatibility issues.

\section downloadusing_using Using the dll

Use the dll to implement your own B2S.Server plugin. The first steps are:

- Create a new class library project in Visual Studio.
- Add a reference the the B2SServerPluginInterface.dll you have downloaded.
- Add a reference to System.ComponentModel.Composition.
- Create a plugin class and implement at least the IDirectPlugin interface.
- Decorate the plugin class with [Export(typeof(B2S.IDirectPlugin))] for C# or &lt;Export(GetType(B2S.IDirectPlugin))&gt; for VB.net.

More information on using the B2SServerPluginInterface.dll to create your own plugins can be found in the <a href="http://directoutput.github.com/B2SServerSamplePlugin/">B2S.Server Sample Plugin project</a>.



