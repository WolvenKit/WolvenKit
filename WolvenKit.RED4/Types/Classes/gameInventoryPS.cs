using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameInventoryPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("isRegisteredShared")] 
		public CBool IsRegisteredShared
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("accessible")] 
		public CBool Accessible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameInventoryPS()
		{
			Accessible = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
