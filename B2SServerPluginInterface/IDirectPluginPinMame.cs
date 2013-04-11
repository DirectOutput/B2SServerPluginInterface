
namespace B2SServerPluginInterface
{
    /// <summary>
    /// Optional interface for plugins, needing updates on important PinMame calls.<br/>
    /// If a plugin does not need these updates, the interface does not need to be implemented.<br/>
    /// \remark Remember that every plugin does also habe to implement the IDrectPlugin interface to make it recognizeable by the plugin host (B2S.Server).
    /// </summary>
    public interface IDirectPluginPinMame
    {
        /// <summary>
        /// This method is called, when the Run method of PinMame gets called.
        /// </summary>
        void PinMameRun();

        /// <summary>
        /// This method is called, when the property Pause of Pinmame gets set to true.
        /// </summary>
        void PinMamePause();

        /// <summary>
        /// This method is called, when the property Pause of Pinmame gets set to false.
        /// </summary>
        void PinMameContinue();

        /// <summary>
        /// This method is called, when the Stop method of Pinmame is called.
        /// </summary>
        void PinMameStop();
    }
}
