using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questSpawnToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)]  [RED("immediate")] public CBool Immediate { get; set; }

		public questSpawnToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
