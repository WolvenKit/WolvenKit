using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeviceSystemBaseControllerPS : MasterControllerPS
	{
		[Ordinal(105)] 
		[RED("quickHacksEnabled")] 
		public CBool QuickHacksEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeviceSystemBaseControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
