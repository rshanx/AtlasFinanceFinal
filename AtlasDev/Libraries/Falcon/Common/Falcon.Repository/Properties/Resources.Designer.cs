﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Falcon.Common.Repository.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Falcon.Common.Repository.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to SELECT PS.&quot;PersonId&quot;, PS.&quot;IdNum&quot;, PS.&quot;Firstname&quot;, PS.&quot;Lastname&quot;, SC.&quot;LegacyOperatorId&quot; AS &quot;LegacyClientCode&quot;, PS.&quot;WebReference&quot;, BRN.&quot;BranchId&quot;, CPY.&quot;Name&quot; AS &quot;Branch&quot;, RGN.&quot;LegacyRegionCode&quot;, RGN.&quot;RegionId&quot;, BRN.&quot;LegacyBranchNum&quot;, PS.&quot;Email&quot;
        ///FROM &quot;PER_Person&quot; PS
        ///LEFT JOIN &quot;PER_Security&quot; SC ON PS.&quot;PersonId&quot; = SC.&quot;PersonId&quot;
        ///LEFT JOIN &quot;BRN_Branch&quot; BRN ON PS.&quot;BranchId&quot; = BRN.&quot;BranchId&quot;
        ///LEFT JOIN &quot;Region&quot; RGN ON BRN.&quot;Region&quot; = RGN.&quot;RegionId&quot;
        ///LEFT JOIN &quot;CPY_Company&quot; CPY ON BRN.&quot;Company&quot; = CPY.&quot;CompanyId&quot;
        ///W [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GetPersonByWebReferenceQuery {
            get {
                return ResourceManager.GetString("GetPersonByWebReferenceQuery", resourceCulture);
            }
        }
    }
}
