using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		private TweakDBID _characterRecordId;

		[Ordinal(26)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}
	}
}
