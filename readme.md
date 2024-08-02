# dotnet-mvc-in-docker

To run locally:
```
cd src
dotnet run
```

To build and run in Docker:
```
docker build -t dieroller
docker run -p 8080:8080 dieroller
```