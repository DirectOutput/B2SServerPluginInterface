﻿namespace B2SServerPluginInterface
{
    /// <summary>
    /// Optional interface for plugins providing some kind of frontend (e.g. a configuration window).<br/>
    /// If a plugin has no frontend, it is not necessary to implement this interface.
    /// </summary>
    public interface IDirectPluginFrontend
    {
        /// <summary>
        /// This method is called by the plugin host (B2S.Server) to tell the plugin to open its frontend.
        /// </summary>
        void PluginShowFrontend();
    }
}