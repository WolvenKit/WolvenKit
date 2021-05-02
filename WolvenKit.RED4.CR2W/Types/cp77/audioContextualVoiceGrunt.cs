using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioContextualVoiceGrunt : CVariable
	{
		private CName _regularGrunt;
		private CName _stealthGrunt;

		[Ordinal(0)] 
		[RED("regularGrunt")] 
		public CName RegularGrunt
		{
			get => GetProperty(ref _regularGrunt);
			set => SetProperty(ref _regularGrunt, value);
		}

		[Ordinal(1)] 
		[RED("stealthGrunt")] 
		public CName StealthGrunt
		{
			get => GetProperty(ref _stealthGrunt);
			set => SetProperty(ref _stealthGrunt, value);
		}

		public audioContextualVoiceGrunt(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
