using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCrowdTemplateCharacterData : RedBaseClass
	{
		private TweakDBID _characterRecordId;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}
	}
}
