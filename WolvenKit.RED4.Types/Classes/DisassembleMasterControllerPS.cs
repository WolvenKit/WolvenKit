
namespace WolvenKit.RED4.Types
{
	public partial class DisassembleMasterControllerPS : MasterControllerPS
	{
		public DisassembleMasterControllerPS()
		{
			DeviceName = "Disassemble Master";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
