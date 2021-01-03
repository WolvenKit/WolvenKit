using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QsTransform : CVariable
	{
		[Ordinal(0)]  [RED("Rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(1)]  [RED("Scale")] public Vector4 Scale { get; set; }
		[Ordinal(2)]  [RED("Translation")] public Vector4 Translation { get; set; }

		public QsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
