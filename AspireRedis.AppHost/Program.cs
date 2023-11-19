var builder = DistributedApplication.CreateBuilder(args);

var apiservice = builder.AddProject<Projects.AspireRedis_ApiService>("apiservice");

builder.AddProject<Projects.AspireRedis_Web>("webfrontend")
    .WithReference(apiservice);

builder.Build().Run();
