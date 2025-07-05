using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(29)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public CpoCharacterButtonItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
