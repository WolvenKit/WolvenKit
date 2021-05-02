using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseAnim : animAnimNode_SkAnim
	{
		private CName _phase;

		[Ordinal(30)] 
		[RED("phase")] 
		public CName Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		public animAnimNode_SkPhaseAnim(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
