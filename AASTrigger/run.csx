#r "Microsoft.AnalysisServices.Tabular.DLL"
#r "Microsoft.AnalysisServices.Core.DLL"
#r "System.Configuration"
using System;
using System.Net;
using System.Configuration;

using Microsoft.AnalysisServices.Tabular;
public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
   try
   {
       var test = "test";
    //  var test = "testing";
    //    return req.CreateResponse(HttpStatusCode.OK, test);
    var connStr = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
    Server server = new Server();
    server.Connect(connStr);
    //test new comment
    // Database db = server.Databases["IICF"];
    // Model m = db.Model;
    // m.RequestRefresh(RefreshType.Full);  
    // m.SaveChanges();
    server.Disconnect();
    return req.CreateResponse(HttpStatusCode.OK, "Succesfully Proccessed AS");
   }
   catch (Exception e)
   {
   return req.CreateResponse(HttpStatusCode.BadRequest, e);
   }
   
  
}
