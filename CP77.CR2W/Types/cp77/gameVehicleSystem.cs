using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVehicleSystem : gameIVehicleSystem
	{
		[Ordinal(0)]  [RED("restrictionTags")] public CArray<CName> RestrictionTags { get; set; }

		public gameVehicleSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
