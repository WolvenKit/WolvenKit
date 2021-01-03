using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameQueryResult : CVariable
	{
		[Ordinal(0)]  [RED("hitShapes")] public CArray<gameShapeData> HitShapes { get; set; }

		public gameQueryResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
