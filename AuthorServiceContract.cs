﻿using System.Diagnostics;
using System.ServiceModel;
using System.Xml.Linq;
namespace SoapingService
{
    [ServiceContract]
    public interface IAuthorService
    {
        [OperationContract]
        void MySoapMethod(XElement xml);
    }
    public class AuthorService : IAuthorService
    {
        public void MySoapMethod(XElement xml)
        {
            Trace.WriteLine(xml.ToString());
        }
    }
}
