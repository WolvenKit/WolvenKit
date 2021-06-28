using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIFlatheadSetSoloModeCommandParams : questScriptedAICommandParams
	{
		private CBool _soloMode;

		[Ordinal(0)] 
		[RED("soloMode")] 
		public CBool SoloMode
		{
			get => GetProperty(ref _soloMode);
			set => SetProperty(ref _soloMode, value);
		}

		public AIFlatheadSetSoloModeCommandParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
