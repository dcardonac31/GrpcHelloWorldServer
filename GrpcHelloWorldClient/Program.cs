using Grpc.Net.Client;
using GrpcHelloWorldClient.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcHelloWorldClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channell = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new HelloService.HelloServiceClient(channell);

            var reply = await client.SayHelloAsync(
                    new HelloRequest { Name = "Grpc Client" }
                );
            
            Console.WriteLine( $"Greetings: {reply.Message}"  );
            Console.ReadKey();
        }
    }
}
