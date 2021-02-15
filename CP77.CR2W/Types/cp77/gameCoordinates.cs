using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCoordinates : CVariable
	{
		[Ordinal(0)] [RED("latitude")] public CInt32 Latitude { get; set; }
		[Ordinal(1)] [RED("longitude")] public CInt32 Longitude { get; set; }

		public gameCoordinates(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
