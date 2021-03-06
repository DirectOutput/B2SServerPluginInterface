﻿
namespace B2SServerPluginInterface
{
    /// <summary>
    /// Interface for plugins for the B2S Server.<br/>
    /// All plugins must implement this interface to be recognized by the B2S Server. 
    /// In addition they also have to export the class implementing the interface using the following attribute  [Export(typeof(B2SServerPluginInterface.IDirectPlugin))] in c# or   &lt;Export(GetType(B2SServerPluginInterface.IDirectPlugin))&gt; for VB.net.
    /// Please refer to the documentation of the B2S.Server Sample Plugin Project (http://directoutput.github.com/B2SServerSamplePlugin/) for more information on plugins.
    /// \remark Be sure to handle all exceptions of your plugin, since the B2S Server will deactivate plugins throwing unhandled exceptions.<br/>
    /// </summary>
    public interface IDirectPlugin
    {
        /// <summary>
        /// This method initalizes the plugin.<br/>
        /// It is the first plugin method beeing called after the plugin has been instanciated.
        /// </summary>
        /// <param name="TableFilename">The filename of the table.</param>
        /// <param name="RomName">Name of the rom (optional).</param>
        void PluginInit(string TableFilename, string RomName = "");

        /// <summary>
        /// Finishes the plugin.<br/>
        /// This is the last method called, before a plugin is discared. This method is also called, after a undhandled exception has occured in a plugin.
        /// </summary>
        void PluginFinish();

        /// <summary>
        /// Gets the name of the plugin. <br/>
        /// It is recommended to add the version/build number of your plugin to the name, so different version can easily be recognized be the end user.
        /// </summary>
        /// <value>
        /// The name of the plugin.
        /// </value>
        string Name { get; }

        /// <summary>
        /// This method is called, when new data from Pinmame or the B2SSetData command for EMTables is available.
        /// \remark Make implementations of this method as fast as possible! Delays in this method will slow down the whole virtual pinball system. The best solution is to put the data in a queue and process it in a independent thread.
        /// </summary>
        /// <param name="TableElementTypeChar">Char representing the table element type (S=Solenoid, W=Switch, L=Lamp, M=Mech, G=GI, E=EMTable, D=Led, ?=Unknown table element type).</param>
        /// <param name="Number">The number of the table element.</param>
        /// <param name="Value">The value of the table element.</param>
        void DataReceive(char TableElementTypeChar, int Number, int Value);


    }

}
