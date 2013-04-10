Interfaces in the B2SServerPluginInterface.dll {#interfaces}
============================================================

\section interfaces_idirectplugin IDirectPlugin Interface

The IDirectPlugin interface is the main interface for plugins. All plugins must implement this interface. Otherwise they will not be recognized by the B2S.Server or other applications hosting the plugin.

See the section on classes for more information about this interface.


\section interfaces_idirectpluginfrontend IDirectPluginFrontEnd Interface

If a plugin has some frontend (e.g. configuration window) it is a good choice to implement the IDirectPluginFrontEnd interface. This interface will allow the host application to open the frontend when necessary.

See the section on classes for more information about this interface.

