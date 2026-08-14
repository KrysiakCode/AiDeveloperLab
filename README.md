# AiDeveloperLab

## Health endpoint

`GET /health` reports the application's health. It returns `200 OK` when all registered health checks are healthy, and `503 Service Unavailable` when one or more checks are unhealthy.

<!-- CI test -->