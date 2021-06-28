using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreviousFearPhaseCheck : AIbehaviorconditionScript
	{
		private CInt32 _fearPhase;

		[Ordinal(0)] 
		[RED("fearPhase")] 
		public CInt32 FearPhase
		{
			get => GetProperty(ref _fearPhase);
			set => SetProperty(ref _fearPhase, value);
		}

		public PreviousFearPhaseCheck(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
