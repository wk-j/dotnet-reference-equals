## Reference Equals

```csharp
public static class HttpMethods {
        // We are intentionally using 'static readonly' here instead of 'const'.
        // 'const' values would be embedded in to each assembly that used them
        // and each consuming assembly would have a different 'string' instance.
        // Using .'static readonly' means that all consumers get thee exact same
        // 'string' instance, which means the 'ReferenceEquals' checks below work
        // and allow us to optimize comparisons when these constants are used.

        // Please do NOT change these to 'const'
        public static readonly string Connect = "CONNECT";
        public static readonly string Delete = "DELETE";
        public static readonly string Get = "GET";
        public static readonly string Head = "HEAD";
        public static readonly string Options = "OPTIONS";
        public static readonly string Patch = "PATCH";
        public static readonly string Post = "POST";
        public static readonly string Put = "PUT";
        public static readonly string Trace = "TRACE";
}
```

- [HttpMethods.cs](https://github.com/dotnet/aspnetcore/blob/48b44dbb92378fededff434fa1dddf3d90a4ac99/src/Http/Http.Abstractions/src/HttpMethods.cs)