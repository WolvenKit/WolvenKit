using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectFilter_PlayerIgnoreFriendlyAndAlive : gameEffectObjectGroupFilter
	{
		private TweakDBID _ignoreCharacterRecord;

		[Ordinal(0)] 
		[RED("ignoreCharacterRecord")] 
		public TweakDBID IgnoreCharacterRecord
		{
			get => GetProperty(ref _ignoreCharacterRecord);
			set => SetProperty(ref _ignoreCharacterRecord, value);
		}
	}
}
