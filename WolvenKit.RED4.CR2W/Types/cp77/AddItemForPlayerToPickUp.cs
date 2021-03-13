using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddItemForPlayerToPickUp : ScriptableDeviceAction
	{
		[Ordinal(25)] [RED("lootTable")] public TweakDBID LootTable { get; set; }
		[Ordinal(26)] [RED("shouldAdd")] public CBool ShouldAdd { get; set; }

		public AddItemForPlayerToPickUp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
