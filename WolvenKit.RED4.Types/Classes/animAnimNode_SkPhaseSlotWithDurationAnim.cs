using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_SkPhaseSlotWithDurationAnim : animAnimNode_SkPhaseWithDurationAnim
	{
		private CName _animFeatureName;
		private CResourceReference<animActionAnimDatabase> _actionAnimDatabaseRef;

		[Ordinal(32)] 
		[RED("animFeatureName")] 
		public CName AnimFeatureName
		{
			get => GetProperty(ref _animFeatureName);
			set => SetProperty(ref _animFeatureName, value);
		}

		[Ordinal(33)] 
		[RED("actionAnimDatabaseRef")] 
		public CResourceReference<animActionAnimDatabase> ActionAnimDatabaseRef
		{
			get => GetProperty(ref _actionAnimDatabaseRef);
			set => SetProperty(ref _actionAnimDatabaseRef, value);
		}
	}
}
