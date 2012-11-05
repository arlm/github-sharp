using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace GitHubSharp.Auth
{
    public class Authenticator : IAuthenticator
    {
        private readonly string username;
        private readonly string password;
        private readonly bool useApiKey;
        private SecretsHandler secrets;

        public Authenticator(string username, string password, bool useApiKey)
        {
            this.username = username;
            this.password = password;
            this.useApiKey = useApiKey;
        }

        public Authenticator(string secretsFile, bool useApiKey)
        {
            this.secrets = new SecretsHandler(secretsFile);
            this.username = secrets.Username;
            this.password = secrets.Password;
            this.useApiKey = useApiKey;
        }

        public void Authenticate(IRestRequest request)
        {
            if (!request.Parameters.Any(p => p.Name.Equals("Authorization", StringComparison.InvariantCultureIgnoreCase)))
            {
                string token;

                if (useApiKey)
                {
                    token =
                        Convert.ToBase64String(
                            Encoding.UTF8.GetBytes(string.Format("{0}/token:{1}", username, password)));
                }
                else
                {
                    token =
                        Convert.ToBase64String(
                            Encoding.UTF8.GetBytes(string.Format("{0}:{1}", username, password)));
                }

                var authHeader = string.Format("Basic {0}", token);
                request.AddParameter("Authorization", authHeader, ParameterType.HttpHeader);
            }
        }

        public void Authenticate(IRestClient client, IRestRequest request)
        {
            Authenticate(request);
        }
    }
}
