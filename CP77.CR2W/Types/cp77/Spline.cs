using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Spline : ISerializable
	{
		[Ordinal(0)]  [RED("hasDirection")] public CBool HasDirection { get; set; }
		[Ordinal(1)]  [RED("looped")] public CBool Looped { get; set; }
		[Ordinal(2)]  [RED("points")] public CArray<SplinePoint> Points { get; set; }
		[Ordinal(3)]  [RED("reversed")] public CBool Reversed { get; set; }

		public Spline(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
