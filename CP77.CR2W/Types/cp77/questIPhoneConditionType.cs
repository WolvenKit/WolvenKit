using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questIPhoneConditionType : questIUIConditionType
	{
		[Ordinal(0)]  [RED("inverted")] public CBool Inverted { get; set; }

		public questIPhoneConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
