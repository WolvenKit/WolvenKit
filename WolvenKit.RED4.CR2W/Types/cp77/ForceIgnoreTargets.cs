using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceIgnoreTargets : ActionBool
	{
		public ForceIgnoreTargets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
