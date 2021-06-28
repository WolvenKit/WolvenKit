using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTrackOutput : CVariable
	{
		private animNamedTrackIndex _targetTrack;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("targetTrack")] 
		public animNamedTrackIndex TargetTrack
		{
			get => GetProperty(ref _targetTrack);
			set => SetProperty(ref _targetTrack, value);
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		public animSimpleBounceTrackOutput(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
