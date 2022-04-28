using Google.Protobuf.WellKnownTypes;

namespace AElf.Contracts.FourthTestContract
{
    /// <summary>
    /// The C# implementation of the contract defined in fourth_test_contract.proto that is located in the "protobuf"
    /// folder.
    /// Notice that it inherits from the protobuf generated code. 
    /// </summary>
    public class FourthTestContract : FourthTestContractContainer.FourthTestContractBase
    {
        /// <summary>
        /// The implementation of the Hello method. It takes no parameters and returns on of the custom data types
        /// defined in the protobuf definition file.
        /// </summary>
        /// <param name="input">Empty message (from Protobuf)</param>
        /// <returns>a HelloReturn</returns>
        public override HelloReturn Hello(Empty input)
        {
            return new HelloReturn {Value = "Hello World!"};
        }

      public override Empty IsRegistered(User input)
        {
            Assert(input.Id == 0,"Wrong Input ");
            if (State.userlist.Value == null)
            {
                State.userlist.Value = new UserList();
            }

            Assert(State.userlist.Value.UserList_.Contains(new User
            {
                Id = input.Id,
                Name = input.Name
            }),"Already registered");
            return new Empty();
            
        }

        public override Empty AddRegister(User input)
        {
            Assert(!(input.Id == 0),"Wrong Input");
            if (State.userlist.Value == null)
            {
                State.userlist.Value = new UserList();
            }
            Assert(!State.userlist.Value.UserList_.Contains(new User
            {
                Id = input.Id,
                Name = input.Name
            }),"Already Registered");
            State.userlist.Value.UserList_.Add(new User
            {
                Id = input.Id,
                Name = input.Name
            });
            return new Empty();
        }

        public override UserList GetUserList(Empty input)   
        {
            return State.userlist.Value;
        }
    }
}