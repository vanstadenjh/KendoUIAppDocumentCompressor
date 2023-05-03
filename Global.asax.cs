using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KendoUIAppDocumentCompressor
{
  public class MvcApplication : System.Web.HttpApplication
  {
    protected void Application_Start()
    {

      //Register Syncfusion license
      Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBaFt+QHJqVk1mQ1NbdF9AXnNIfll0QWlYfk4BCV5EYF5SRHNfQVxjS3pSdE1jWno=;Mgo+DSMBPh8sVXJ1S0R+X1pCaV1dX2NLfUN3RWlbe1RxdUU3HVdTRHRcQlhjSn9TdEFiW3dccHE=;ORg4AjUWIQA/Gnt2VFhiQlJPcEBAQmFJfFBmRGNTfVp6dVRWESFaRnZdQV1mSX1SdkdnWH1WdHVQ;MTkwODg4NUAzMjMxMmUzMjJlMzNXOFVZcDU0RkZ4amRuamdKU2dGblhNYm9zTlNtM0hma2xlZVBsNU5RaEZ3PQ==;MTkwODg4NkAzMjMxMmUzMjJlMzNlWE9uQm1LUnJFdm1qNllQT1BoVm83a2RZa1AvVzYwMS9YQldtOWE3ZndVPQ==;NRAiBiAaIQQuGjN/V0d+Xk9HfVldX3xLflF1VWJZdVx0flRHcC0sT3RfQF5jTH5Qd0VhXX5ceXVXRw==;MTkwODg4OEAzMjMxMmUzMjJlMzNhYzZFT2hGNTFkSlN1dUxXQXliYVZROTdBT05EQXRNZ2JRcjlreDZxWXFBPQ==;MTkwODg4OUAzMjMxMmUzMjJlMzNYTVlGK1dYRmd0M3ZlSlhiOXFVZTh2VlpVWUJ2c0lVaWc5LzdvVkFNT2pBPQ==;Mgo+DSMBMAY9C3t2VFhiQlJPcEBAQmFJfFBmRGNTfVp6dVRWESFaRnZdQV1mSX1SdkdnWH1Xd3xW;MTkwODg5MUAzMjMxMmUzMjJlMzNhUWY4U1BocG5GbHF1eDdhZmduV2tSbVhkNUFjSzQ4Vzducjk3Vm4rTjVVPQ==;MTkwODg5MkAzMjMxMmUzMjJlMzNWY3k4c0dJQTI5NG1wdHFwZ001ZnI2d1NHMXJpQVV4VGY3MU8yUGRXNDQ4PQ==;MTkwODg5M0AzMjMxMmUzMjJlMzNhYzZFT2hGNTFkSlN1dUxXQXliYVZROTdBT05EQXRNZ2JRcjlreDZxWXFBPQ==");

      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
    }
  }
}
