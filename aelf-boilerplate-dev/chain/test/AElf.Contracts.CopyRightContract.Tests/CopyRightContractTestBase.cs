using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.CopyRightContract
{
    public class CopyRightContractTestBase : DAppContractTestBase<CopyRightContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal CopyRightContractContainer.CopyRightContractStub GetCopyRightContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<CopyRightContractContainer.CopyRightContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}