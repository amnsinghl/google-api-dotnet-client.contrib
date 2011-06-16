//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Diacritize.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class LanguageDiacritizeCorpusResource : Google.Apis.Requests.IResponse {
        
        private string diacritized_text;
        
        private Google.Apis.Requests.RequestError error;
        
        [Newtonsoft.Json.JsonPropertyAttribute("diacritized_text")]
        public virtual string Diacritized_text {
            get {
                return this.diacritized_text;
            }
            set {
                this.diacritized_text = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
    }
}
namespace Google.Apis.Diacritize.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class DiacritizeService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "diacritize";
        
        private const string BaseUri = "https://www.googleapis.com//language/diacritize/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private DiacritizeResource diacritize;
        
        public DiacritizeService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.diacritize = new DiacritizeResource(this);
        }
        
        public DiacritizeService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", DiacritizeService.Name, DiacritizeService.Version)))).GetService(DiacritizeService.Version, DiacritizeService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(DiacritizeService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual DiacritizeResource Diacritize {
            get {
                return this.diacritize;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, object> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (string.IsNullOrEmpty(DeveloperKey) == false) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, object body, System.Collections.Generic.IDictionary<string, object> parameters) {
            return this.ExecuteRequest(resource, method, this.ObjectToJson(body), parameters);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string ObjectToJson(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T JsonToObject<T>(System.IO.Stream stream)
         {
            return genericService.DeserializeResponse<T>(stream);
        }
    }
    
    public class DiacritizeResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "diacritize";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(DiacritizeResource));
        
        private CorpusResource corpus;
        
        public DiacritizeResource(DiacritizeService service) {
            this.service = service;
            this.corpus = new CorpusResource(service);
        }
        
        public virtual CorpusResource Corpus {
            get {
                return this.corpus;
            }
        }
        
        public class CorpusResource {
            
            private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
            
            private const string Resource = "diacritize.corpus";
            
            private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(CorpusResource));
            
            public CorpusResource(DiacritizeService service) {
                this.service = service;
            }
            
            /// <summary>Adds diacritical marks to the given message.</summary>
            /// <param name="lang">Required - Language of the message</param>
            /// <param name="last_letter">Required - Flag to indicate whether the last letter in a word should be diacritized or not</param>
            /// <param name="message">Required - Message to be diacritized</param>
            public virtual System.IO.Stream GetAsStream(string lang, bool last_letter, string message) {
                string body = null;
                System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
                parameters["lang"] = lang;
                parameters["last_letter"] = last_letter;
                parameters["message"] = message;
                logger.Debug("Executing corpus.get");
                System.IO.Stream ret = this.service.ExecuteRequest(CorpusResource.Resource, "get", body, parameters);
                logger.Debug("Done Executing corpus.get");
                return ret;
            }
            
            /// <summary>Adds diacritical marks to the given message.</summary>
            /// <param name="lang">Required - Language of the message</param>
            /// <param name="last_letter">Required - Flag to indicate whether the last letter in a word should be diacritized or not</param>
            /// <param name="message">Required - Message to be diacritized</param>
            public virtual Google.Apis.Diacritize.V1.Data.LanguageDiacritizeCorpusResource Get(string lang, bool last_letter, string message) {
                string body = null;
                System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
                parameters["lang"] = lang;
                parameters["last_letter"] = last_letter;
                parameters["message"] = message;
                logger.Debug("Executing corpus.get");
                Google.Apis.Diacritize.V1.Data.LanguageDiacritizeCorpusResource ret = this.service.JsonToObject<Google.Apis.Diacritize.V1.Data.LanguageDiacritizeCorpusResource>(this.service.ExecuteRequest(CorpusResource.Resource, "get", body, parameters));
                logger.Debug("Done Executing corpus.get");
                return ret;
            }
        }
    }
}
