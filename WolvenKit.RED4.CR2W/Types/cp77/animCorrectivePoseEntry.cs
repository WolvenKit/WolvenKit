using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animCorrectivePoseEntry : CVariable
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

		public animCorrectivePoseEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
