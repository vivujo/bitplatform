﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Foundation.CSharpAnalyzers {
    using System;
    using System.Reflection;
    
    
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
    public class FoundationAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal FoundationAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Foundation.CSharpAnalyzers.FoundationAnalyzersResources", typeof(FoundationAnalyzersResources).GetTypeInfo().Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analzyer which enforces usage of camel case naming for OData action &amp; function parameter names.
        /// </summary>
        public static string CamelCaseParameterNameAnalyzerDescription {
            get {
                return ResourceManager.GetString("CamelCaseParameterNameAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use camel case parameter name.
        /// </summary>
        public static string CamelCaseParameterNameAnalyzerMessage {
            get {
                return ResourceManager.GetString("CamelCaseParameterNameAnalyzerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use caml case parameter name.
        /// </summary>
        public static string CamelCaseParameterNameAnalyzerTitle {
            get {
                return ResourceManager.GetString("CamelCaseParameterNameAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analzyer which enforces usage modifiers in classes.
        /// </summary>
        public static string ClassWithoutModifierAnalyzerDescription {
            get {
                return ResourceManager.GetString("ClassWithoutModifierAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add modifier to your class.
        /// </summary>
        public static string ClassWithoutModifierAnalyzerMessage {
            get {
                return ResourceManager.GetString("ClassWithoutModifierAnalyzerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add modifier to your class.
        /// </summary>
        public static string ClassWithoutModifierAnalyzerTitle {
            get {
                return ResourceManager.GetString("ClassWithoutModifierAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analzyer which enforces usage of DateTimeOffset instead of DateTime.
        /// </summary>
        public static string DateTimeOffsetInsteadOfDateTimeAnalyzerDescription {
            get {
                return ResourceManager.GetString("DateTimeOffsetInsteadOfDateTimeAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use DateTimeOffset instead of DateTime.
        /// </summary>
        public static string DateTimeOffsetInsteadOfDateTimeAnalyzerMessage {
            get {
                return ResourceManager.GetString("DateTimeOffsetInsteadOfDateTimeAnalyzerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Replace DateTime usage with DateTimeOffset.
        /// </summary>
        public static string DateTimeOffsetInsteadOfDateTimeAnalyzerTitle {
            get {
                return ResourceManager.GetString("DateTimeOffsetInsteadOfDateTimeAnalyzerTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analyzer which deny you from using internal on your properties accessors.
        /// </summary>
        public static string PropertyAccessorsInternalModifierAnalyzerDescription {
            get {
                return ResourceManager.GetString("PropertyAccessorsInternalModifierAnalyzerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Property&apos;s accessors may not be internal.
        /// </summary>
        public static string PropertyAccessorsInternalModifierAnalyzerMessage {
            get {
                return ResourceManager.GetString("PropertyAccessorsInternalModifierAnalyzerMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove internal from modifiers of your property&apos;s accessors.
        /// </summary>
        public static string PropertyAccessorsInternalModifierAnalyzerTitle {
            get {
                return ResourceManager.GetString("PropertyAccessorsInternalModifierAnalyzerTitle", resourceCulture);
            }
        }
    }
}
