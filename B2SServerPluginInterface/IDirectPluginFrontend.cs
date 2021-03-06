﻿using System.Windows.Forms;
namespace B2SServerPluginInterface
{
    /// <summary>
    /// Optional interface for plugins providing some kind of frontend (e.g. a configuration window).<br/>
    /// If a plugin has no frontend, it is not necessary to implement this interface.
    /// \remark Remember that every plugin does also has to implement the IDrectPlugin interface to make it recognizeable by the plugin host (B2S.Server).
    /// </summary>
    public interface IDirectPluginFrontend
    {
        /// <summary>
        /// This method is called by the plugin host (B2S.Server) to tell the plugin to open its frontend.
        /// </summary>
        /// <param name="Owner">(optional) The owner window for the frontend.<br/>Make sure you also support null/nothing for this parameter.</param>
        void PluginShowFrontend(Form Owner = null);
    }
}
