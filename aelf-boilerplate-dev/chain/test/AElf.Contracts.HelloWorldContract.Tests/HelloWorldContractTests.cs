using System.Linq;
using System.Threading.Tasks;
using AElf.ContractTestBase.ContractTestKit;
using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Shouldly;
using Xunit;

namespace AElf.Contracts.HelloWorldContract
{
    public class HelloWorldContractTests : HelloWorldContractTestBase
    {
        private Account account20 = SampleAccount.Accounts[20];
        private Account account10 = SampleAccount.Accounts[10];
        
        
        [Fact]
        public async Task Test()
        {
            // Get a stub for testing.
            var keyPair = SampleAccount.Accounts.First().KeyPair;
            var stub = GetHelloWorldContractStub(keyPair);
            
            // Use CallAsync or SendAsync method of this stub to test.
            // await stub.Hello.SendAsync(new Empty())
    
            // Or maybe you want to get its return value.
            // var output = (await stub.Hello.SendAsync(new Empty())).Output;

            // Or transaction result.
            // var transactionResult = (await stub.Hello.SendAsync(new Empty())).TransactionResult;

            var test = new HelloReturn
            {
                Value = "Hello World",
            };
/*            var result = (await stub.Hello.SendAsync(new Empty())).Output;
            result.ShouldBe(test);
*/
            //var result = (await stub.Hello.SendAsync(new Empty())).Output;
            //result.ShouldBe(test);

            var result = (await stub.HelloTest2.SendAsync(new Empty())).Output;
            result.ShouldBe(test);
            
        }

        
        
    }
}