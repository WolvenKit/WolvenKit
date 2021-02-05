using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questICharacterConditionType : questIConditionType
	{
		[Ordinal(0)]  [RED("childRef")] public gameEntityReference ChildRef { get; set; }
		[Ordinal(1)]  [RED("childIsPlayer")] public CBool ChildIsPlayer { get; set; }

		public questICharacterConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
