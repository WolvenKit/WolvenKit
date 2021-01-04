using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportedTile : CVariable
	{
		[Ordinal(0)]  [RED("colorMapAbsolutePath")] public CString ColorMapAbsolutePath { get; set; }
		[Ordinal(1)]  [RED("controlMapAbsolutePath")] public CString ControlMapAbsolutePath { get; set; }
		[Ordinal(2)]  [RED("heightMapAbsolutePath")] public CString HeightMapAbsolutePath { get; set; }
		[Ordinal(3)]  [RED("position")] public Point Position { get; set; }

		public interopTerrainImportedTile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
