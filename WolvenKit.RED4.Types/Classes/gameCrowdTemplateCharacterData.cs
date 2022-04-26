using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdTemplateCharacterData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCrowdTemplateCharacterData()
		{
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
