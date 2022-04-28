using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.ThirdTestContract
{
    public class ThirdTestContractTestBase : DAppContractTestBase<ThirdTestContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal ThirdTestContractContainer.ThirdTestContractStub GetThirdTestContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<ThirdTestContractContainer.ThirdTestContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}