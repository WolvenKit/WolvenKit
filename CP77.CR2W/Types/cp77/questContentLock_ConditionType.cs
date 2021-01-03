using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questContentLock_ConditionType : questIContentConditionType
	{
		[Ordinal(0)]  [RED("isContentBlocked")] public CBool IsContentBlocked { get; set; }

		public questContentLock_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
