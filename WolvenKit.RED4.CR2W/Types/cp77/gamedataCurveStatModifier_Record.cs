using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataCurveStatModifier_Record : gamedataStatModifier_Record
	{
		public gamedataCurveStatModifier_Record(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
