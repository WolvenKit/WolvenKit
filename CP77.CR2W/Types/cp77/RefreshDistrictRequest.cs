using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RefreshDistrictRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("preventionPreset")] public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset { get; set; }

		public RefreshDistrictRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
