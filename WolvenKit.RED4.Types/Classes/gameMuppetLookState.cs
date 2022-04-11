using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetLookState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lookDir")] 
		public EulerAngles LookDir
		{
			get => GetPropertyValue<EulerAngles>();
			set => SetPropertyValue<EulerAngles>(value);
		}

		public gameMuppetLookState()
		{
			LookDir = new();
		}
	}
}
