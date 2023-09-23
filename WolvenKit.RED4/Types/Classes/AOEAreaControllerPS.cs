using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AOEAreaControllerPS : MasterControllerPS
	{
		[Ordinal(108)] 
		[RED("AOEAreaSetup")] 
		public AOEAreaSetup AOEAreaSetup
		{
			get => GetPropertyValue<AOEAreaSetup>();
			set => SetPropertyValue<AOEAreaSetup>(value);
		}

		public AOEAreaControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
