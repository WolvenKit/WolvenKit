using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class District : IScriptable
	{
		[Ordinal(0)]  [RED("districtID")] public TweakDBID DistrictID { get; set; }
		[Ordinal(1)]  [RED("presetID")] public TweakDBID PresetID { get; set; }

		public District(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
