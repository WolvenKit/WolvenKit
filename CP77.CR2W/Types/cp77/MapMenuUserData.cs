using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MapMenuUserData : IScriptable
	{
		[Ordinal(0)] [RED("moveTo")] public Vector3 MoveTo { get; set; }

		public MapMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
