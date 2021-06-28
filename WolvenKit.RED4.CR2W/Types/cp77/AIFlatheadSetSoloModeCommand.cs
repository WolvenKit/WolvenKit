using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommand : AIFollowerCommand
	{
		private CBool _soloModeState;

		[Ordinal(5)] 
		[RED("soloModeState")] 
		public CBool SoloModeState
		{
			get => GetProperty(ref _soloModeState);
			set => SetProperty(ref _soloModeState, value);
		}

		public AIFlatheadSetSoloModeCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
