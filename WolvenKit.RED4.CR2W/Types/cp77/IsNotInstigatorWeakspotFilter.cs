using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsNotInstigatorWeakspotFilter : gameEffectObjectSingleFilter_Scripted
	{
		public IsNotInstigatorWeakspotFilter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
