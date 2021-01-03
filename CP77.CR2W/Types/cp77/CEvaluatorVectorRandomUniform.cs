using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		[Ordinal(0)]  [RED("lockW")] public CBool LockW { get; set; }
		[Ordinal(1)]  [RED("lockX")] public CBool LockX { get; set; }
		[Ordinal(2)]  [RED("lockY")] public CBool LockY { get; set; }
		[Ordinal(3)]  [RED("lockZ")] public CBool LockZ { get; set; }
		[Ordinal(4)]  [RED("max")] public Vector4 Max { get; set; }
		[Ordinal(5)]  [RED("min")] public Vector4 Min { get; set; }

		public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
