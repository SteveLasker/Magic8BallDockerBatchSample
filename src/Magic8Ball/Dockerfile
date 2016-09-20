FROM microsoft/dotnet:1.0.1-core
ARG source=.
WORKDIR /app
COPY $source .
#use ENTRYPOINT to define the startup process and it's parameters
# leaving CMD undefined to support input parameters
ENTRYPOINT ["dotnet", "Magic8Ball.dll"]
