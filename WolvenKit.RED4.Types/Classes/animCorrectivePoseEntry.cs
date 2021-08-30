using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animCorrectivePoseEntry : RedBaseClass
	{
		private CName _comparePose;
		private CName _correctivePose;
		private CArray<CName> _jointsToCompare;
		private CBool _enabled;

		[Ordinal(0)] 
		[RED("comparePose")] 
		public CName ComparePose
		{
			get => GetProperty(ref _comparePose);
			set => SetProperty(ref _comparePose, value);
		}

		[Ordinal(1)] 
		[RED("correctivePose")] 
		public CName CorrectivePose
		{
			get => GetProperty(ref _correctivePose);
			set => SetProperty(ref _correctivePose, value);
		}

		[Ordinal(2)] 
		[RED("jointsToCompare")] 
		public CArray<CName> JointsToCompare
		{
			get => GetProperty(ref _jointsToCompare);
			set => SetProperty(ref _jointsToCompare, value);
		}

		[Ordinal(3)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetProperty(ref _enabled);
			set => SetProperty(ref _enabled, value);
		}

		public animCorrectivePoseEntry()
		{
			_enabled = true;
		}
	}
}
