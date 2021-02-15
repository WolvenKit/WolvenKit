using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIISerializableArgumentInstancePS : AIArgumentInstancePS
	{
		[Ordinal(1)] [RED("value")] public CHandle<ISerializable> Value { get; set; }

		public AIISerializableArgumentInstancePS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
