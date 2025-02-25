// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

// 
//This source code was auto-generated by MonoXSD
//
namespace CMakeListGenerator {
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("makefile", Namespace="", IsNullable=false)]
    public partial class Makefile {
        
        private string dependField;
        
        private Package[] neededpackagesField;
        
        private Files[] filesField;
        
        private Directory[] directoriesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string depend {
            get {
                return this.dependField;
            }
            set {
                this.dependField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArray(ElementName="needed-packages", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItem(ElementName="package", IsNullable=false, Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Package[] neededpackages {
            get {
                return this.neededpackagesField;
            }
            set {
                this.neededpackagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("files", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Files[] files {
            get {
                return this.filesField;
            }
            set {
                this.filesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArray(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItem(ElementName="directory", IsNullable=false, Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Directory[] directories {
            get {
                return this.directoriesField;
            }
            set {
                this.directoriesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Package {
        
        private string nameField;
        
        private bool optionalField;
        
        private bool optionalSpecifiedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool optional {
            get {
                return this.optionalField;
            }
            set {
                this.optionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool optionalSpecified {
            get {
                return this.optionalSpecifiedField;
            }
            set {
                this.optionalSpecifiedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Files {
        
        private Language languageField;
        
        private File[] fileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Language language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("file", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public File[] file {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    public enum Language {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("c++")]
        c,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("c++header")]
        cheader,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("c")]
        c1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("cheader")]
        cheader1,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("c#")]
        c2,
        
        /// <remarks/>
        module,
        
        /// <remarks/>
        service,
        
        /// <remarks/>
        f90,
        
        /// <remarks/>
        axl,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("axl[strong]")]
        axlstrong,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("axl[case+strong]")]
        axlcasestrong,
        
        /// <remarks/>
        law,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("law[debug]")]
        lawdebug,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("law[sequential]")]
        lawsequential,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("law[inference=onnx]")]
        lawinferenceonnx,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("service[strong]")]
        servicestrong,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("service[case+strong]")]
        servicecasestrong,
        
        /// <remarks/>
        gump,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class File {
        
        private bool headerField;
        
        private bool headerSpecifiedField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool headerSpecified {
            get {
                return this.headerSpecifiedField;
            }
            set {
                this.headerSpecifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17020")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.ifpen.fr/ArcGeoSim")]
    public partial class Directory {
        
        private string dependField1;
        
        private bool recursiveField;
        
        private bool recursiveSpecifiedField;
        
        private string valueField1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Namespace="")]
        public string depend {
            get {
                return this.dependField1;
            }
            set {
                this.dependField1 = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Namespace="")]
        public bool recursive {
            get {
                return this.recursiveField;
            }
            set {
                this.recursiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnore()]
        public virtual bool recursiveSpecified {
            get {
                return this.recursiveSpecifiedField;
            }
            set {
                this.recursiveSpecifiedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField1;
            }
            set {
                this.valueField1 = value;
            }
        }
    }
}
