using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCombatNodeParams_UseCover : questCombatNodeParams
	{
		private NodeRef _cover;
		private CBool _oneTimeSelection;
		private CArray<CEnum<AICoverExposureMethod>> _forceStance;
		private CName _forcedEntryAnimation;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("cover")] 
		public NodeRef Cover
		{
			get => GetProperty(ref _cover);
			set => SetProperty(ref _cover, value);
		}

		[Ordinal(1)] 
		[RED("oneTimeSelection")] 
		public CBool OneTimeSelection
		{
			get => GetProperty(ref _oneTimeSelection);
			set => SetProperty(ref _oneTimeSelection, value);
		}

		[Ordinal(2)] 
		[RED("forceStance")] 
		public CArray<CEnum<AICoverExposureMethod>> ForceStance
		{
			get => GetProperty(ref _forceStance);
			set => SetProperty(ref _forceStance, value);
		}

		[Ordinal(3)] 
		[RED("forcedEntryAnimation")] 
		public CName ForcedEntryAnimation
		{
			get => GetProperty(ref _forcedEntryAnimation);
			set => SetProperty(ref _forcedEntryAnimation, value);
		}

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get => GetProperty(ref _immediately);
			set => SetProperty(ref _immediately, value);
		}
	}
}
