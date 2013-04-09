About
=====
The B2S.Server has been implemented by Stefan/<a href="http://www.vpforums.org/index.php?showuser=57523">Herweh</a>. He has been kind enough to add a plugin infrasturucture to the B2S.Server, so other libraries can listen to the dataflow of Pinmame as well.
\image html Herweh.png

The B2SServerPluginInterface.dll has been implemented by <a href="http://www.vpforums.org/index.php?showuser=58068">SwissLizard</a>.
\image html swisslizard.png 

\mainpage notitle

\image html B2SServerPluginInterface.png

B2S.Server Plugin Interface Documentation
=========================================

The B2S.Server by Stefan/<a href="http://www.vpforums.org/index.php?showuser=57523">Herweh</a> acts as a proxy between Visual Pinball and Pinmame. To allow other libraries to listen to the dataflow between Visual Pinball and Pinmame as weel, a plugin infrastructure exists in the B2S.Server.

To allow the B2S.Server to discover plugins, all plugins must implement a common interface. These interfaces are defined in the B2SServerPluginInterface.dll. This documentation will show you how to use these interfaces in your own plugin and explain the members of the interface.

