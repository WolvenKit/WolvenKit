using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LeftHandCyberwareLoopDecisions : LeftHandCyberwareTransition
	{
		public LeftHandCyberwareLoopDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
