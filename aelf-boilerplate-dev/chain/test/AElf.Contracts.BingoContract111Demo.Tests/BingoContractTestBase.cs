using AElf.Boilerplate.TestBase;
using AElf.Cryptography.ECDSA;

namespace AElf.Contracts.BingoContract111Demo
{
    public class BingoContractTestBase : DAppContractTestBase<BingoContractTestModule>
    {
        // You can get address of any contract via GetAddress method, for example:
        // internal Address DAppContractAddress => GetAddress(DAppSmartContractAddressNameProvider.StringName);

        internal BingoContractContainer.BingoContractStub GetBingoContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<BingoContractContainer.BingoContractStub>(DAppContractAddress, senderKeyPair);
        }
    }
}