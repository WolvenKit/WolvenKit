using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneStatus_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)]  [RED("customStatus")] public CName CustomStatus { get; set; }
		[Ordinal(1)]  [RED("status")] public CEnum<questPhoneStatus> Status { get; set; }

		public questSetPhoneStatus_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
