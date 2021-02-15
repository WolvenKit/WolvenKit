using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameItemDropObject : gameLootObject
	{
		[Ordinal(43)] [RED("wasItemInitialized")] public CBool WasItemInitialized { get; set; }

		public gameItemDropObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
