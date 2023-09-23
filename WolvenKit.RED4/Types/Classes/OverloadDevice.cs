using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverloadDevice : ActionBool
	{
		[Ordinal(38)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public OverloadDevice()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
