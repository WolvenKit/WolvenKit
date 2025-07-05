using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterManagerParameters_SetLowGravity : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questCharacterManagerParameters_SetLowGravity()
		{
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
