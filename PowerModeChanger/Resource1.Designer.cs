﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PowerModeChanger {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PowerModeChanger.Resource1", typeof(Resource1).Assembly);
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
        
        /// <summary>
        ///   Looks up a localized string similar to powercfg /setactive 381b4222-f694-41f0-9685-ff5bb260df2e
        ///
        ///if errorlevel 1 goto fehler
        ///echo off
        ///:fehler
        ///msg %username% Your message here.
        /// </summary>
        internal static string Balanced {
            get {
                return ResourceManager.GetString("Balanced", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to powercfg /setactive 6fecc5ae-f350-48a5-b669-b472cb895ccf
        ///if errorlevel 1 goto fehler
        ///echo off
        ///:fehler
        ///msg %username% Your message here.
        /// </summary>
        internal static string High_Performance {
            get {
                return ResourceManager.GetString("High_Performance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System.Collections.Generic;
        ///using System.ComponentModel;
        ///using System.Data;
        ///using System.Drawing;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Windows.Forms;
        ///using System.Diagnostics;
        ///using System.IO;
        ///using System.Threading;
        ///
        ///
        ///
        ///namespace PowerModeChanger
        ///{
        ///    public partial class Form1 : Form
        ///    {
        ///        public Form1()
        ///        {
        ///	InitializeComponent();
        ///
        ///        }
        ///
        ///        private void Button1_Click(object sender, EventArgs e)
        ///        {
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PowerSafer {
            get {
                return ResourceManager.GetString("PowerSafer", resourceCulture);
            }
        }
    }
}