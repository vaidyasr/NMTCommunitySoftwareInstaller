﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4016
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace com.nmtinstaller.csi.Panels {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class pnlSelectApplication {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal pnlSelectApplication() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("com.nmtinstaller.csi.Panels.pnlSelectApplication", typeof(pnlSelectApplication).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static System.Windows.Forms.ImageListStreamer ilIcons_ImageStream {
            get {
                object obj = ResourceManager.GetObject("ilIcons.ImageStream", resourceCulture);
                return ((System.Windows.Forms.ImageListStreamer)(obj));
            }
        }
        
        internal static System.Drawing.Point ilIcons_TrayLocation {
            get {
                object obj = ResourceManager.GetObject("ilIcons.TrayLocation", resourceCulture);
                return ((System.Drawing.Point)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please select desired item to install then click next to start the installation or upgrade.
        ///
        ///The Installed tab will offer additional actions for installed applications like uninstall.
        ///Please note that the Installed tab will only list install applications. 
        ///Use Extra -&gt; Uninstall to uninstall other items..
        /// </summary>
        internal static string lblSelectApplication_Text {
            get {
                return ResourceManager.GetString("lblSelectApplication.Text", resourceCulture);
            }
        }
    }
}
