using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Crypto.Tls;
using Secp256k1Net;

namespace AElf.Contracts.TestFirstContract
{
    /// <summary>
    /// The C# implementation of the contract defined in test_first_contract.proto that is located in the "protobuf"
    /// folder.
    /// Notice that it inherits from the protobuf generated code. 
    /// </summary>
    public class TestFirstContract : TestFirstContractContainer.TestFirstContractBase
    {
        /// <summary>
        /// The implementation of the Hello method. It takes no parameters and returns on of the custom data types
        /// defined in the protobuf definition file.
        /// </summary>
        /// <param name="input">Empty message (from Protobuf)</param>
        /// <returns>a HelloReturn</returns>
        public override HelloReturn Hello(Empty input)
        
        {
            return new HelloReturn
            {
                Value = "admin123456"
            };
        }

        public override HelloReturn TestHello(HelloReturn input)
        {
            return new HelloReturn
            {
                Value = input.Value
            };
        }


        // 注册普通用户
        public override BoolReturn RegisteUser(User input)
        {
            bool flag = true;
            if (State.userid.Value == 0)
            {
                State.userid.Value = 1;
            }

            if (State.userlist.Value == null)
            {
                State.userlist.Value = new UserList();
            }


            foreach (var tmp_user in State.userlist.Value.UserList_)
            {
                if (tmp_user.Name == input.Name)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                State.userlist.Value.UserList_.Add(new User
                {
                    Id = State.userid.Value,
                    Name = input.Name,
                    Pass = input.Pass,
                    RegisterTime = Context.CurrentBlockTime,
                    Telephone = input.Telephone,
                    Mail = input.Mail,
                    ProjectList = { }
                    
                });

                State.userid.Value += 1;
    
            } 
           
            return new BoolReturn
            {
                Returnflag = flag
            };
        }

        // 注册管理员
        public override BoolReturn RegisteAdmin(Admin input)
        {
            bool flag = true;
            if (State.adminid.Value == 0)
            {
                State.adminid.Value = 1;
            }

            if (State.adminlist.Value == null)
            {
                State.adminlist.Value = new AadminList();
            }

            foreach (var tmp_admin in State.adminlist.Value.AdminList)
            {
                if (tmp_admin.Name == input.Name)
                {
                    flag = false;
                }
            }

            if (flag)
            {
                State.adminlist.Value.AdminList.Add(new Admin
                {
                    Id = State.adminid.Value,
                    Name = input.Name,
                    Pass = input.Pass
                });
                State.adminid.Value += 1;
            }

            return new BoolReturn
            {
                Returnflag = flag
            };
        }
        
        // addProject
        public override BoolReturn AddProject(Project input)
        {
            var flag = true;
            if (State.handleprojectid.Value == 0)
            {
                State.handleprojectid.Value = 1;
            }

            if (State.waitaddprojectlist.Value == null)
            {
                State.waitaddprojectlist.Value = new WaitAddProjectList();
            }

            if (State.addprojectid.Value == 0)
            {
                State.addprojectid.Value = 1;
            }
            var tmp_project = new Project
            {
                Id = State.handleprojectid.Value,
                Company = input.Company,
                Name = input.Name,
                RegisteTime = Context.CurrentBlockTime,
                RegsiterName = input.RegsiterName,
                Status = "InProcess",
                Type = input.Type
            };
            State.waitaddprojectlist.Value.WaitAddProjectList_.Add(tmp_project);
            State.handleprojectid.Value += 1;
            return new BoolReturn
            {
                Returnflag = flag
            };
        }
        public override BoolReturn HandleProject(HandleProjectListId input)
        {
            var flag = false;
            var tmpproject = new Project();
            if (State.addedprojectlist.Value == null)
            {
                State.addedprojectlist.Value = new AddedProjectList();
            }
            foreach (var tmp_project in State.waitaddprojectlist.Value.WaitAddProjectList_)
            {
                if (tmp_project.Id == input.Id)
                {
                    flag = true;
                    tmpproject = tmp_project;
                }
            }
            if (flag)
            {
                tmpproject.Id = State.addprojectid.Value;
                tmpproject.Status = "Handlered";
                State.addedprojectlist.Value.AddedProjectList_.Add(tmpproject);
                //Assert(false,"1211111111111");
                State.addprojectid.Value += 1;
                
            }
            return new BoolReturn
            {
                Returnflag = flag
            };
        }


        // 普通用户登录
        public override BoolReturn LoginUser(PassLogin input)
        {
            bool flag = false;
            foreach (var tmp_user in State.userlist.Value.UserList_)
            {
                if (tmp_user.Name == input.Name && tmp_user.Pass == input.Pass)
                {
                    flag = true;
                } 
            }

            return new BoolReturn
            {
                Returnflag = flag
            };
        }
        
        // 管理员登录
        public override BoolReturn LoginAdmin(PassLogin input)
        {
            bool flag = false;
            foreach (var tmp_admin in State.adminlist.Value.AdminList)
            {
                if (tmp_admin.Name == input.Name && tmp_admin.Pass == input.Pass)
                {
                    flag = true;
                }
            }
            return new BoolReturn
            {
                Returnflag = flag
            };
        }


        /*public override UserList GetUserList(Empty input)
        {
            return State.userlist.Value;
        }*/
        public override UserList GetUserList(Empty input)
        {

            State.userlist.Value = new UserList();
            State.userlist.Value.UserList_.Add(new User
            {
                Id = 10,
                Name = "aaa"
            });
            return State.userlist.Value;
        }
        
        
        

        public override AadminList GetAadminList(Empty input)
        {
            return State.adminlist.Value;
        }

        public override WaitAddProjectList GetWaitProjectList(Empty input)
        {
            return State.waitaddprojectlist.Value;
        }

        public override AddedProjectList GetAddedProjectList(Empty input)
        {
            return State.addedprojectlist.Value;
        }

        /*public override Int32Value Getuserid(Empty input)
        {
            return new Int32Value{Value = State.userid.Value};
        }*/
        public override Int32Value Getuserid(Empty input)
        {
            State.userid.Value = 20;
            return new Int32Value{Value = State.userid.Value};
        }

        public override Empty Setuserid(Empty input)
        {
            State.userid.Value = 1;
            return new Empty();
        }
    }
    
}