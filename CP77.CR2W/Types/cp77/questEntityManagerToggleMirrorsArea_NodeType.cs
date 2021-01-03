using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerToggleMirrorsArea_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)]  [RED("isInMirrorsArea")] public CBool IsInMirrorsArea { get; set; }
		[Ordinal(1)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }

		public questEntityManagerToggleMirrorsArea_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
