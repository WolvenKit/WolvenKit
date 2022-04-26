using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MovableDeviceSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("numberOfUses")] 
		public CInt32 NumberOfUses
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public MovableDeviceSetup()
		{
			NumberOfUses = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
