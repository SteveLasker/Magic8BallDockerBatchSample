# Magic8BallDockerBatchSample
A sample for how to call batch jobs with docker

Docker containers start instantly, and always start in a clean state. So, why not run your batch jobs as containes?
In this really simple sample, I pass a string (a question for the magic 8 ball) and return an answer. This could take a customer_id and process their taxes, or create a thumbnail for a image url passed in.
Using `ENTRYPOINT` as a JSON array, we can tell docker what to run by default, and leave the parameters to the input passed to the container. 

Run the following command:

`docker run stevelasker/magic8ballbatchsample "Are you a square container?"`

  The answer to your question: 'Are you a square container?' is Without a doubt

##Building##
To build this project, from a commandline in the same folder as your source and dockerfiles
```
dotnet restore
dotnet publish -c release -o ./publish
docker-compose -f publish\docker-compose.yml -p "magic8ball" build
```
