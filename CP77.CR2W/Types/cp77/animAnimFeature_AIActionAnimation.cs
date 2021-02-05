using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_AIActionAnimation : animAnimFeature_AIAction
	{
		[Ordinal(0)]  [RED("direction")] public CFloat Direction { get; set; }
		[Ordinal(1)]  [RED("animFeatureName")] public CName AnimFeatureName { get; set; }

		public animAnimFeature_AIActionAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
