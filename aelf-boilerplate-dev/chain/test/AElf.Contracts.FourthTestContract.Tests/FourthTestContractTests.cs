using System;
using System.Linq;
using System.Threading.Tasks;
using AElf.ContractTestBase.ContractTestKit;
using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Shouldly;
using Xunit;

namespace AElf.Contracts.FourthTestContract
{
    public class FourthTestContractTests : FourthTestContractTestBase
    {
        private Account account20 = SampleAccount.Accounts[20];
        
       // [Fact]
        public async Task Test()
        {
            // Get a stub for testing.
            var keyPair = SampleAccount.Accounts.First().KeyPair;
            var stub = GetFourthTestContractStub(keyPair);


            var keypair20 = SampleAccount.Accounts[20].KeyPair;
            var keypair20stub = GetFourthTestContractStub(keypair20);
            // Use CallAsync or SendAsync method of this stub to test.
            // await stub.Hello.SendAsync(new Empty())

            // Or maybe you want to get its return value.
            // var output = (await stub.Hello.SendAsync(new Empty())).Output;

            // Or transaction result.
            // var transactionResult = (await stub.Hello.SendAsync(new Empty())).TransactionResult;
            var user_tmp = new User
            {
                Id = 1,
                Name = "hacker",
            };
            
        }

        [Fact]
        public async Task AddRegisterTest()
        {
            var keyPair = SampleAccount.Accounts.First().KeyPair;
            var stub = GetFourthTestContractStub(keyPair);
    
            var tmp_user = new User();
            tmp_user.Id = 2;
            tmp_user.Name = "test2";
            
            await stub.AddRegister.SendAsync(new User
            {
                Id = 1,
                Name = "test1"
            });
            
            await stub.AddRegister.SendAsync(new User
            {
                Id = 2,
               Name = "test2"
            });
            

            var result = (await stub.GetUserList.SendAsync(new Empty())).Output;
            var exist = result.UserList_.Contains(tmp_user);
            exist.ShouldBe(true);

            

        }
        

    }
}