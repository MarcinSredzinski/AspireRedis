var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.AspireRedis_ApiService>("apiservice");

builder.AddProject<Projects.AspireRedis_Web>("webfrontend")
    .WithReference(apiservice)
    .WithReference(redis);

builder.Build().Run();
