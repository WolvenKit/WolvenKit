using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemModificationSystem : gameScriptableSystem
	{
		[Ordinal(0)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }

		public ItemModificationSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
