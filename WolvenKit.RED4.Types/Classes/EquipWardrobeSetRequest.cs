using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquipWardrobeSetRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("setID")] 
		public CInt32 SetID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public EquipWardrobeSetRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
