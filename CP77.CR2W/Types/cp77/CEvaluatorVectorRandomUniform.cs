using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorRandomUniform : IEvaluatorVector
	{
		[Ordinal(2)] [RED("min")] public Vector4 Min { get; set; }
		[Ordinal(3)] [RED("max")] public Vector4 Max { get; set; }
		[Ordinal(4)] [RED("lockX")] public CBool LockX { get; set; }
		[Ordinal(5)] [RED("lockY")] public CBool LockY { get; set; }
		[Ordinal(6)] [RED("lockZ")] public CBool LockZ { get; set; }
		[Ordinal(7)] [RED("lockW")] public CBool LockW { get; set; }

		public CEvaluatorVectorRandomUniform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
