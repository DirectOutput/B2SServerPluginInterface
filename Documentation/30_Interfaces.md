Interfaces in the B2SServerPluginInterface.dll {#interfaces}
============================================================

\section interfaces_idirectplugin IDirectPlugin Interface

The IDirectPlugin interface is the main interface for plugins. All plugins must implement this interface. Otherwise they will not be recognized by the B2S.Server or other applications hosting the plugin.

The interface implementation looks as follows (if the comment are removed):

~~~~~~~~~~~~~{.cs}
    public interface IDirectPlugin
    {
        string Name { get; }

        void PluginInit(string TableFilename, string RomName = "");

        void PluginFinish();

        void DataReceive(char TableElementTypeChar, int Number, int Value);
    }
~~~~~~~~~~~~~

See the section on classes for more information about this interface and the description of its members.

\section interfaces_idirectpluginpinmame IDirectPluginPinMame Interface

This optional interface allows a plugin to receive updastes on important PinMame actions like Run, Stop and Pause.

The interface is implemented as follows:

~~~~~~~~~~~~~{.cs}
    public interface IDirectPluginPinMame
    {
        void PinMameRun();

        void PinMamePause();

        void PinMameContinue();

        void PinMameStop();
    }
~~~~~~~~~~~~~

See the section on classes for more information about this interface and the description of its members.


\section interfaces_idirectpluginfrontend IDirectPluginFrontEnd Interface

If a plugin has some frontend (e.g. configuration window) it is a good choice to implement the IDirectPluginFrontEnd interface. This interface will allow the host application to open the frontend when necessary.

The optional Owner parameter (make sure your implementation does also accept calls with null for the parameter) is used to pass a reference to the owner window for the frontend. This allows to ensure that your frontend windows are centered on the call window and/or that the frontend windows are put on the same screen as the calling appilcation.

~~~~~~~~~~~~~{.cs}
    public interface IDirectPluginFrontend
    {
        void PluginShowFrontend(Form Owner = null);
    }
~~~~~~~~~~~~~

See the section on classes for more information about this interface and the description of its members.

