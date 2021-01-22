using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		[Ordinal(0)]  [RED("lootTable")] public TweakDBID LootTable { get; set; }
		[Ordinal(1)]  [RED("shouldAdd")] public CBool ShouldAdd { get; set; }

		public AddItemForPlayerToPickUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
