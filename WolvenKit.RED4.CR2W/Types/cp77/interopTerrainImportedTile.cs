using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class interopTerrainImportedTile : CVariable
	{
		[Ordinal(0)] [RED("heightMapAbsolutePath")] public CString HeightMapAbsolutePath { get; set; }
		[Ordinal(1)] [RED("controlMapAbsolutePath")] public CString ControlMapAbsolutePath { get; set; }
		[Ordinal(2)] [RED("colorMapAbsolutePath")] public CString ColorMapAbsolutePath { get; set; }
		[Ordinal(3)] [RED("position")] public Point Position { get; set; }

		public interopTerrainImportedTile(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
