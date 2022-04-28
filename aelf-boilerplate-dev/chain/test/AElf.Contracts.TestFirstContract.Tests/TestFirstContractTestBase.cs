using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.TestFirstContract
{
    public class TestFirstContractTestBase : DAppContractTestBase<TestFirstContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal TestFirstContractContainer.TestFirstContractStub GetTestFirstContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<TestFirstContractContainer.TestFirstContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}