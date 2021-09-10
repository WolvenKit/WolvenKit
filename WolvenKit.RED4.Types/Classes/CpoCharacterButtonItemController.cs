using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
