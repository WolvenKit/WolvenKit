using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QsTransform : CVariable
	{
		[Ordinal(0)] [RED("Translation")] public Vector4 Translation { get; set; }
		[Ordinal(1)] [RED("Rotation")] public Quaternion Rotation { get; set; }
		[Ordinal(2)] [RED("Scale")] public Vector4 Scale { get; set; }

		public QsTransform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
