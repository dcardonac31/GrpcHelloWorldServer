using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace GrpcGreeterClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using var channell = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channell);

            var reply = await client.SayHelloAsync(
                    new HelloRequest { Name = "Grpc Greeter Client" }
                );

            Console.WriteLine($"Greetings: {reply.Message}");
            Console.ReadKey();
        }
    }
}
