using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.FourthTestContract
{
    public class FourthTestContractTestBase : DAppContractTestBase<FourthTestContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal FourthTestContractContainer.FourthTestContractStub GetFourthTestContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<FourthTestContractContainer.FourthTestContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}