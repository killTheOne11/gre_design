using System.Linq;
using System.Threading.Tasks;
using AElf.ContractTestBase.ContractTestKit;
using AElf.Types;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Secp256k1Net;
using Shouldly;
using Xunit;

namespace AElf.Contracts.TestFirstContract
{
    public class TestFirstContractTests : TestFirstContractTestBase
    {
        private Account account20 = SampleAccount.Accounts[20];
        private Account account10 = SampleAccount.Accounts[10];
        
        
        //[Fact]
        public async Task Test()
        {
            // Get a stub for testing.
            var keyPair = SampleAccount.Accounts.First().KeyPair;
            var stub = GetTestFirstContractStub(keyPair);
            
            // Use CallAsync or SendAsync method of this stub to test.
            // await stub.Hello.SendAsync(new Empty())
    
            // Or maybe you want to get its return value.
            // var output = (await stub.Hello.SendAsync(new Empty())).Output;

            // Or transaction result.
            // var transactionResult = (await stub.Hello.SendAsync(new Empty())).TransactionResult;

            var test = new HelloReturn
            {
                Value = "Hello World!",
            };
/*            var result = (await stub.Hello.SendAsync(new Empty())).Output;
            result.ShouldBe(test);
*/
            //var result = (await stub.Hello.SendAsync(new Empty())).Output;
            //result.ShouldBe(test);

            var result = (await stub.Hello.SendAsync(new Empty())).Output;
            result.ShouldBe(test);
            
        }

        //[Fact]
        public async Task test1()
        {
            var keypair = SampleAccount.Accounts[0].KeyPair;
            var stub = GetTestFirstContractStub(keypair);
            var tmp_user = new User
            {
                Id = 1,
                Name = "aaa",
                Mail = "123Q@QQ.COM",
                Pass = "123456",
                RegisterTime = new Timestamp(),
                Telephone = "120"
            };
            await stub.RegisteUser.SendAsync(new User
            {
                Id = 1,
                Name = "aaa",
                Mail = "123Q@QQ.COM",
                Pass = "123456",
                RegisterTime = new Timestamp(),
                Telephone = "120",
                ProjectList = { }
            });
            
           var result =  (await stub.RegisteUser.SendAsync(new User
            {
                Id = 1,
                Name = "aaa",
                Mail = "123Q@QQ.COM",
                Pass = "123456",
                RegisterTime = new Timestamp(),
                Telephone = "120",
                ProjectList = {  }
            })).Output;
           var tmp_return = new BoolReturn
           {
                Returnflag = false
           };
            result.ShouldBe(tmp_return);
            
           /* var result = (await stub.GetUserList.SendAsync(new Empty())).Output;
            var exist = result.UserList_.Contains(tmp_user);
            exist.ShouldBe(false);*/

        }


        //[Fact]
        public async Task testRegisadmin()
        {
            var keypair = ContractTestKit.SampleAccount.Accounts[0].KeyPair;
            var stub = GetTestFirstContractStub(keypair);

            await stub.RegisteAdmin.SendAsync(new Admin
            {
                Name = "admin"
            });
            
            var result = (await stub.RegisteAdmin.SendAsync(new Admin
            {
                Id = 1,
                Name = "admin",
                Pass = "123456"
            })).Output;
            result.ShouldBe(new BoolReturn
            {
                Returnflag = false
            });
        }

        //[Fact]
        public async Task testLogin()
        {
   /*         var keypair = SampleAccount.Accounts[0].KeyPair;
            var stub = GetTestFirstContractStub(keypair);
            await stub.RegisteUser.SendAsync(new User
            {
                Id = 1,
                Name = "aaa",
                Mail = "123Q@QQ.COM",
                Pass = "123456",
                RegisterTime = new Timestamp(),
                Telephone = "120",
                ProjectList = { }
            });
            var tmp_login = new PassLogin
            {
                Name = "aaa",
                Pass = "1234567"
            };
            var result = (await stub.LoginUser.SendAsync(tmp_login)).Output;
            result.ShouldBe(new BoolReturn
            {
                Returnflag = false
            });
*/
            var keypair = SampleAccount.Accounts[0].KeyPair;
            var stub = GetTestFirstContractStub(keypair);
            await stub.RegisteAdmin.SendAsync(new Admin
            {
                Id = 1,
                Name = "admin",
                Pass = "123456"
            });
            var tmp_login = new PassLogin
            {
                Name = "admin",
                Pass = "1234567"
            };
            var result = (await stub.LoginAdmin.SendAsync(tmp_login)).Output;
            result.ShouldBe(new BoolReturn
            {
                Returnflag = true
            });

        }

        [Fact]
        public async Task testaddproject()
        {
            var keypair = SampleAccount.Accounts[0].KeyPair;
            var stub = GetTestFirstContractStub(keypair);
            var tmp_project = new Project
            {
                Id = 1,
                Company = "aaa",
                Name = "txt",
                RegisteTime = new Timestamp(),
                Status = "123",
                RegsiterName = "txt",
                Type = 1
            };
            var tmp_project2 = new Project
            {
                Id = 1,
                Company = "bbb",
                Name = "txt",
                RegisteTime = new Timestamp(),
                Status = "123",
                RegsiterName = "txt",
                Type = 1
            };
            await stub.AddProject.SendAsync(tmp_project);
            await stub.AddProject.SendAsync(tmp_project2);
            var tmp = new HandleProjectListId
            {
                Id = 2
            };
            var result = (await stub.HandleProject.SendAsync(tmp)).Output;
            result.ShouldBe(new BoolReturn
            { 
                Returnflag = true
            });
        }
        
        
    }
}