using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsApplyStatusEffectEvent : gameeventsStatusEffectEvent
	{
		private CBool _isNewApplication;
		private entEntityID _instigatorEntityID;
		private CBool _isAppliedOnSpawn;

		[Ordinal(2)] 
		[RED("isNewApplication")] 
		public CBool IsNewApplication
		{
			get => GetProperty(ref _isNewApplication);
			set => SetProperty(ref _isNewApplication, value);
		}

		[Ordinal(3)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get => GetProperty(ref _instigatorEntityID);
			set => SetProperty(ref _instigatorEntityID, value);
		}

		[Ordinal(4)] 
		[RED("isAppliedOnSpawn")] 
		public CBool IsAppliedOnSpawn
		{
			get => GetProperty(ref _isAppliedOnSpawn);
			set => SetProperty(ref _isAppliedOnSpawn, value);
		}
	}
}
