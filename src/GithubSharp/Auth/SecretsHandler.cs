using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace GitHubSharp.Auth
{
    public class SecretsHandler
    {
        private readonly secrets _secrets;

        public SecretsHandler(string file)
        {
            file = Environment.ExpandEnvironmentVariables(file);

            if(File.Exists(file))
            {
                using(var fstream = new FileStream(file, FileMode.Open))
                {
                    var serializer = new XmlSerializer(typeof (secrets));
                    _secrets = (secrets) serializer.Deserialize(fstream);
                }
            }
        }

        public string Username
        {
            get { return _secrets.username; }
        }

        public string Password
        {
            get { return _secrets.password; }
        }

        public string Token
        {
            get { return _secrets.token; }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class secrets
    {

        private string usernameField;
        private string passwordField;
        private string tokenField;

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NewDataSet
    {

        private secrets[] itemsField;

        [System.Xml.Serialization.XmlElementAttribute("secrets")]
        public secrets[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
