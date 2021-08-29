using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimTargetsEvent : redEvent
	{
		private CArray<StimTargetData> _targets;
		private CBool _restore;

		[Ordinal(0)] 
		[RED("targets")] 
		public CArray<StimTargetData> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(1)] 
		[RED("restore")] 
		public CBool Restore
		{
			get => GetProperty(ref _restore);
			set => SetProperty(ref _restore, value);
		}
	}
}
