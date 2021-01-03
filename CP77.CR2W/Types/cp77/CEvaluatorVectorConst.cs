using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorConst : IEvaluatorVector
	{
		[Ordinal(0)]  [RED("value")] public Vector4 Value { get; set; }

		public CEvaluatorVectorConst(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
