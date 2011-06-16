//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.TaskQueue.V1Beta1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Task : Google.Apis.Requests.IResponse {
        
        private string enqueueTimestamp;
        
        private string id;
        
        private string kind;
        
        private string leaseTimestamp;
        
        private string payloadBase64;
        
        private string queueName;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>Time (in seconds since the epoch) at which the task was enqueued.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enqueueTimestamp")]
        public virtual string EnqueueTimestamp {
            get {
                return this.enqueueTimestamp;
            }
            set {
                this.enqueueTimestamp = value;
            }
        }
        
        /// <summary>Name of the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The kind of object returned, in this case set to task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Time (in seconds since the epoch) at which the task lease will expire. This value is 0 if the task isnt currently leased out to a worker.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("leaseTimestamp")]
        public virtual string LeaseTimestamp {
            get {
                return this.leaseTimestamp;
            }
            set {
                this.leaseTimestamp = value;
            }
        }
        
        /// <summary>A bag of bytes which is the task payload. The payload on the JSON side is always Base64 encoded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payloadBase64")]
        public virtual string PayloadBase64 {
            get {
                return this.payloadBase64;
            }
            set {
                this.payloadBase64 = value;
            }
        }
        
        /// <summary>Name of the queue that the task is in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queueName")]
        public virtual string QueueName {
            get {
                return this.queueName;
            }
            set {
                this.queueName = value;
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
    
    public class Taskqueue : Google.Apis.Requests.IResponse {
        
        private AclData acl;
        
        private string id;
        
        private string kind;
        
        private long maxLeases;
        
        private StatsData stats;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>ACLs that are applicable to this TaskQueue object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("acl")]
        public virtual AclData Acl {
            get {
                return this.acl;
            }
            set {
                this.acl = value;
            }
        }
        
        /// <summary>Name of the taskqueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>The kind of REST object returned, in this case taskqueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>The number of times we should lease out tasks before giving up on them. If unset we lease them out forever until a worker deletes the task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxLeases")]
        public virtual long MaxLeases {
            get {
                return this.maxLeases;
            }
            set {
                this.maxLeases = value;
            }
        }
        
        /// <summary>Statistics for the TaskQueue object in question.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stats")]
        public virtual StatsData Stats {
            get {
                return this.stats;
            }
            set {
                this.stats = value;
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
        
        /// <summary>ACLs that are applicable to this TaskQueue object.</summary>
        public class AclData {
            
            private IList<System.String> adminEmails;
            
            private IList<System.String> consumerEmails;
            
            private IList<System.String> producerEmails;
            
            /// <summary>Email addresses of users who are &quot;admins&quot; of the TaskQueue. This means they can control the queue, eg set ACLs for the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("adminEmails")]
            public virtual IList<System.String> AdminEmails {
                get {
                    return this.adminEmails;
                }
                set {
                    this.adminEmails = value;
                }
            }
            
            /// <summary>Email addresses of users who can &quot;consume&quot; tasks from the TaskQueue. This means they can Dequeue and Delete tasks from the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("consumerEmails")]
            public virtual IList<System.String> ConsumerEmails {
                get {
                    return this.consumerEmails;
                }
                set {
                    this.consumerEmails = value;
                }
            }
            
            /// <summary>Email addresses of users who can &quot;produce&quot; tasks into the TaskQueue. This means they can Insert tasks into the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("producerEmails")]
            public virtual IList<System.String> ProducerEmails {
                get {
                    return this.producerEmails;
                }
                set {
                    this.producerEmails = value;
                }
            }
        }
        
        /// <summary>Statistics for the TaskQueue object in question.</summary>
        public class StatsData {
            
            private string leasedLastHour;
            
            private string leasedLastMinute;
            
            private string oldestTask;
            
            private long totalTasks;
            
            /// <summary>Number of tasks leased in the last hour.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("leasedLastHour")]
            public virtual string LeasedLastHour {
                get {
                    return this.leasedLastHour;
                }
                set {
                    this.leasedLastHour = value;
                }
            }
            
            /// <summary>Number of tasks leased in the last minute.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("leasedLastMinute")]
            public virtual string LeasedLastMinute {
                get {
                    return this.leasedLastMinute;
                }
                set {
                    this.leasedLastMinute = value;
                }
            }
            
            /// <summary>The timestamp (in seconds since the epoch) of the oldest unfinished task.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("oldestTask")]
            public virtual string OldestTask {
                get {
                    return this.oldestTask;
                }
                set {
                    this.oldestTask = value;
                }
            }
            
            /// <summary>Number of tasks in the queue.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("totalTasks")]
            public virtual long TotalTasks {
                get {
                    return this.totalTasks;
                }
                set {
                    this.totalTasks = value;
                }
            }
        }
    }
    
    public class Tasks : Google.Apis.Requests.IResponse {
        
        private IList<Task> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>The actual list of tasks returned as a result of the lease operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Task> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>The kind of object returned, a list of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
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
    
    public class Tasks2 : Google.Apis.Requests.IResponse {
        
        private IList<Task> items;
        
        private string kind;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>The actual list of tasks currently active in the TaskQueue.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Task> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>The kind of object returned, a list of tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
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
namespace Google.Apis.TaskQueue.V1Beta1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class TaskqueueService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1beta1";
        
        private const string Name = "taskqueue";
        
        private const string BaseUri = "https://www.googleapis.com//taskqueue/v1beta1/projects/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private TaskqueuesResource taskqueues;
        
        private TasksResource tasks;
        
        public TaskqueueService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.taskqueues = new TaskqueuesResource(this);
            this.tasks = new TasksResource(this);
        }
        
        public TaskqueueService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", TaskqueueService.Name, TaskqueueService.Version)))).GetService(TaskqueueService.Version, TaskqueueService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(TaskqueueService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
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
        
        public virtual TaskqueuesResource Taskqueues {
            get {
                return this.taskqueues;
            }
        }
        
        public virtual TasksResource Tasks {
            get {
                return this.tasks;
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
    
    public class TaskqueuesResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "taskqueues";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(TaskqueuesResource));
        
        public TaskqueuesResource(TaskqueueService service) {
            this.service = service;
        }
        
        /// <summary>Get detailed information about a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The id of the taskqueue to get the properties of.</param>
        /// <param name="getStats">Optional - Whether to get stats. Optional.</param>
        public virtual System.IO.Stream GetAsStream(string project, string taskqueue, bool getStats) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            parameters["getStats"] = getStats;
            logger.Debug("Executing taskqueues.get");
            System.IO.Stream ret = this.service.ExecuteRequest(TaskqueuesResource.Resource, "get", body, parameters);
            logger.Debug("Done Executing taskqueues.get");
            return ret;
        }
        
        /// <summary>Get detailed information about a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The id of the taskqueue to get the properties of.</param>
        /// <param name="getStats">Optional - Whether to get stats. Optional.</param>
        public virtual Google.Apis.TaskQueue.V1Beta1.Data.Taskqueue Get(string project, string taskqueue, bool getStats) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            parameters["getStats"] = getStats;
            logger.Debug("Executing taskqueues.get");
            Google.Apis.TaskQueue.V1Beta1.Data.Taskqueue ret = this.service.JsonToObject<Google.Apis.TaskQueue.V1Beta1.Data.Taskqueue>(this.service.ExecuteRequest(TaskqueuesResource.Resource, "get", body, parameters));
            logger.Debug("Done Executing taskqueues.get");
            return ret;
        }
        
        /// <summary>Get detailed information about a TaskQueue.</summary>
        /// <param name="projectValue">project - Required - The project under which the queue lies.</param>
        /// <param name="taskqueueValue">taskqueue - Required - The id of the taskqueue to get the properties of.</param>
        public virtual System.IO.Stream Get(string project, string taskqueue, System.Collections.Generic.IDictionary<string, object> parameters) {
            string body = null;
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing taskqueues.get");
            System.IO.Stream ret = this.service.ExecuteRequest(TaskqueuesResource.Resource, "get", body, parameters);
            logger.Debug("Done Executing taskqueues.get");
            return ret;
        }
    }
    
    public class TasksResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "tasks";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(TasksResource));
        
        public TasksResource(TaskqueueService service) {
            this.service = service;
        }
        
        /// <summary>Delete a task from a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="task">Required - The id of the task to delete.</param>
        /// <param name="taskqueue">Required - The taskqueue to delete a task from.</param>
        public virtual System.IO.Stream DeleteAsStream(string project, string task, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["task"] = task;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.delete");
            System.IO.Stream ret = this.service.ExecuteRequest(TasksResource.Resource, "delete", body, parameters);
            logger.Debug("Done Executing tasks.delete");
            return ret;
        }
        
        /// <summary>Get a particular task from a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="task">Required - The task to get properties of.</param>
        /// <param name="taskqueue">Required - The taskqueue in which the task belongs.</param>
        public virtual System.IO.Stream GetAsStream(string project, string task, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["task"] = task;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.get");
            System.IO.Stream ret = this.service.ExecuteRequest(TasksResource.Resource, "get", body, parameters);
            logger.Debug("Done Executing tasks.get");
            return ret;
        }
        
        /// <summary>Lease 1 or more tasks from a TaskQueue.</summary>
        /// <param name="leaseSecs">Required - The lease in seconds.</param>
        /// <param name="numTasks">Required - The number of tasks to lease.</param>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The taskqueue to lease a task from.</param>
        public virtual System.IO.Stream LeaseAsStream(string body, long leaseSecs, long numTasks, string project, string taskqueue) {
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["leaseSecs"] = leaseSecs;
            parameters["numTasks"] = numTasks;
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.lease");
            System.IO.Stream ret = this.service.ExecuteRequest(TasksResource.Resource, "lease", body, parameters);
            logger.Debug("Done Executing tasks.lease");
            return ret;
        }
        
        /// <summary>List Tasks in a TaskQueue</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The id of the taskqueue to list tasks from.</param>
        public virtual System.IO.Stream ListAsStream(string project, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.list");
            System.IO.Stream ret = this.service.ExecuteRequest(TasksResource.Resource, "list", body, parameters);
            logger.Debug("Done Executing tasks.list");
            return ret;
        }
        
        /// <summary>Delete a task from a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="task">Required - The id of the task to delete.</param>
        /// <param name="taskqueue">Required - The taskqueue to delete a task from.</param>
        public virtual System.IO.Stream Delete(string project, string task, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["task"] = task;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.delete");
            System.IO.Stream ret = this.service.ExecuteRequest(TasksResource.Resource, "delete", body, parameters);
            logger.Debug("Done Executing tasks.delete");
            return ret;
        }
        
        /// <summary>Get a particular task from a TaskQueue.</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="task">Required - The task to get properties of.</param>
        /// <param name="taskqueue">Required - The taskqueue in which the task belongs.</param>
        public virtual Google.Apis.TaskQueue.V1Beta1.Data.Task Get(string project, string task, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["task"] = task;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.get");
            Google.Apis.TaskQueue.V1Beta1.Data.Task ret = this.service.JsonToObject<Google.Apis.TaskQueue.V1Beta1.Data.Task>(this.service.ExecuteRequest(TasksResource.Resource, "get", body, parameters));
            logger.Debug("Done Executing tasks.get");
            return ret;
        }
        
        /// <summary>Lease 1 or more tasks from a TaskQueue.</summary>
        /// <param name="leaseSecs">Required - The lease in seconds.</param>
        /// <param name="numTasks">Required - The number of tasks to lease.</param>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The taskqueue to lease a task from.</param>
        public virtual Google.Apis.TaskQueue.V1Beta1.Data.Tasks Lease(string body, long leaseSecs, long numTasks, string project, string taskqueue) {
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["leaseSecs"] = leaseSecs;
            parameters["numTasks"] = numTasks;
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.lease");
            Google.Apis.TaskQueue.V1Beta1.Data.Tasks ret = this.service.JsonToObject<Google.Apis.TaskQueue.V1Beta1.Data.Tasks>(this.service.ExecuteRequest(TasksResource.Resource, "lease", body, parameters));
            logger.Debug("Done Executing tasks.lease");
            return ret;
        }
        
        /// <summary>List Tasks in a TaskQueue</summary>
        /// <param name="project">Required - The project under which the queue lies.</param>
        /// <param name="taskqueue">Required - The id of the taskqueue to list tasks from.</param>
        public virtual Google.Apis.TaskQueue.V1Beta1.Data.Tasks2 List(string project, string taskqueue) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["project"] = project;
            parameters["taskqueue"] = taskqueue;
            logger.Debug("Executing tasks.list");
            Google.Apis.TaskQueue.V1Beta1.Data.Tasks2 ret = this.service.JsonToObject<Google.Apis.TaskQueue.V1Beta1.Data.Tasks2>(this.service.ExecuteRequest(TasksResource.Resource, "list", body, parameters));
            logger.Debug("Done Executing tasks.list");
            return ret;
        }
    }
}
