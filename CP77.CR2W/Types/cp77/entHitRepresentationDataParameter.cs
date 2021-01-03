using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entHitRepresentationDataParameter : entEntityParameter
	{
		[Ordinal(0)]  [RED("hitRepresentationOverrides")] public CArray<gameHitRepresentationOverride> HitRepresentationOverrides { get; set; }

		public entHitRepresentationDataParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
