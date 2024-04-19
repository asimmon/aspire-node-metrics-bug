using Microsoft.Extensions.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

builder.AddNpmApp("nodeapp", Path.Combine("..", "nodeapp"), "watch")
    .WithDaprSidecar()
    .WithHttpEndpoint(port: 3000, env: "PORT")
    .WithEnvironment("NODE_TLS_REJECT_UNAUTHORIZED", builder.Environment.IsDevelopment() ? "0" : "1");

builder.Build().Run();
