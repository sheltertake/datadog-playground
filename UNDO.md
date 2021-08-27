environment variables:

installer:
DD_DOTNET_TRACER_HOME C:\Program Files\Datadog\.NET Tracer\
DD_INTEGRATIONS C:\Program Files\Datadog\.NET Tracer\integrations.json


settings:
DD_LOGS_INJECTION true
DD_RUNTIME_METRICS_ENABLED true

---

agent:

C:\ProgramData\Datadog\logs empty
C:\ProgramData\Datadog .NET Tracer\logs empty
C:\inetpub\logs\LogFiles empty

    - aspdotnet
    - csharp
    - dotnetclr
    - iis

---

https://app.datadoghq.eu/account/settings
https://app.datadoghq.eu/logs
https://app.datadoghq.eu/logs/livetail
https://app.datadoghq.eu/apm/services?env=development&start=1627535776371&end=1627539376371&paused=false