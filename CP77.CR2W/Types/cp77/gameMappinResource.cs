using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMappinResource : CResource
	{
		[Ordinal(0)]  [RED("cookedData")] public CArray<gameCookedMappinData> CookedData { get; set; }
		[Ordinal(1)]  [RED("cookedGpsData")] public CArray<gameCookedGpsMappinData> CookedGpsData { get; set; }
		[Ordinal(2)]  [RED("cookedMultiData")] public CArray<gameCookedMultiMappinData> CookedMultiData { get; set; }

		public gameMappinResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
