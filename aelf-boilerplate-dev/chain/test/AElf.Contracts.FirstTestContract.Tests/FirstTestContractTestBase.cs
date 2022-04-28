using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.FirstTestContract
{
    public class FirstTestContractTestBase : DAppContractTestBase<FirstTestContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal FirstTestContractContainer.FirstTestContractStub GetFirstTestContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<FirstTestContractContainer.FirstTestContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}