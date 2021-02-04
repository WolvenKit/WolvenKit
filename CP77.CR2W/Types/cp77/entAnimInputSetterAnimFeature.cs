using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimInputSetterAnimFeature : entAnimInputSetter
	{
		[Ordinal(0)]  [RED("value")] public CHandle<animAnimFeature> Value { get; set; }
		[Ordinal(1)]  [RED("delay")] public CFloat Delay { get; set; }

		public entAnimInputSetterAnimFeature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
