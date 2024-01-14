# hc-5991

https://github.com/ChilliCream/graphql-platform/issues/5991

- `dotnet watch --no-hot-reload`
- http://localhost:5095

```
fail: Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware[1]
      An unhandled exception has occurred while executing the request.
      HotChocolate.SchemaException: For more details look at the `Errors` property.

      1. Expression of type 'System.Void' cannot be used for assignment to type 'System.Object' (HotChocolate.Types.StaticObjectTypeExtension)

         at HotChocolate.Configuration.TypeInitializer.DiscoverTypes()
         at HotChocolate.Configuration.TypeInitializer.Initialize()
         at HotChocolate.SchemaBuilder.Setup.InitializeTypes(SchemaBuilder builder, IDescriptorContext context, IReadOnlyList`1 types)
         at HotChocolate.SchemaBuilder.Setup.Create(SchemaBuilder builder, LazySchema lazySchema, IDescriptorContext context)
         at HotChocolate.SchemaBuilder.Create(IDescriptorContext context)
         at HotChocolate.SchemaBuilder.HotChocolate.ISchemaBuilder.Create(IDescriptorContext context)
         at HotChocolate.Execution.RequestExecutorResolver.CreateSchemaAsync(ConfigurationContext context, RequestExecutorSetup setup, RequestExecutorOptions executorOptions, IServiceProvider schemaServices, TypeModuleChangeMonitor typeModuleChangeMonitor, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.CreateSchemaServicesAsync(ConfigurationContext context, RequestExecutorSetup setup, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.GetRequestExecutorNoLockAsync(String schemaName, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorResolver.GetRequestExecutorAsync(String schemaName, CancellationToken cancellationToken)
         at HotChocolate.Execution.RequestExecutorProxy.GetRequestExecutorAsync(CancellationToken cancellationToken)
         at HotChocolate.AspNetCore.HttpPostMiddlewareBase.HandleRequestAsync(HttpContext context)
         at HotChocolate.AspNetCore.HttpPostMiddlewareBase.InvokeAsync(HttpContext context)
         at Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions.<>c__DisplayClass19_0.<<UseCancellation>b__1>d.MoveNext()
      --- End of stack trace from previous location ---
```