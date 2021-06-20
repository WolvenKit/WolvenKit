using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanAIReactToStimTypeFilter : gameEffectObjectSingleFilter_Scripted
	{

		public CanAIReactToStimTypeFilter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
