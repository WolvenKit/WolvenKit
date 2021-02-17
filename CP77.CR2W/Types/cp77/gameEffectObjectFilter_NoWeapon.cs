using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_NoWeapon : gameEffectObjectSingleFilter
	{
		public gameEffectObjectFilter_NoWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
