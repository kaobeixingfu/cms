﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ops.Cms.Infrastructure.Resources {
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
    internal class CmsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal CmsResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ops.Cms.Infrastructure.Resources.CmsResource", typeof(CmsResource).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///&lt;lang&gt;
        ///  &lt;item key=&quot;PAGE_NO_TAGS&quot; Zh_CN=&quot;无标签&quot; Zh_TW=&quot;无标签&quot; En_US=&quot;no tags&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_PrePageText&quot; Zh_CN=&quot;上一页&quot; Zh_TW=&quot;上一頁&quot; En_US=&quot;Previous&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_NextPageText&quot; Zh_CN=&quot;下一页&quot; Zh_TW=&quot;下一頁&quot; En_US=&quot;Next&quot;/&gt;
        ///  &lt;item key=&quot;PAGER_SelectPageText&quot; Zh_CN=&quot;选择页码：{0}页&quot; Zh_TW=&quot;選擇頁碼：{0}頁&quot; En_US=&quot;Select Page：{0}&quot;/&gt;
        ///  &lt;item key=&quot;PAGE_PagerTitle&quot; Zh_CN=&quot;(第{0}页)&quot; Zh_TW=&quot;(第{0}頁)&quot; En_US=&quot;(Page:{0})&quot;/&gt;
        ///&lt;/lang&gt;.
        /// </summary>
        internal static string lang_package {
            get {
                return ResourceManager.GetString("lang_package", resourceCulture);
            }
        }
    }
}
