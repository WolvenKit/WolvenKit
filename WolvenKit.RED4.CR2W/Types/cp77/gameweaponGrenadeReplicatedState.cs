using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponGrenadeReplicatedState : netIEntityState
	{
		[Ordinal(2)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }
		[Ordinal(3)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(4)] [RED("currentTransform")] public WorldTransform CurrentTransform { get; set; }
		[Ordinal(5)] [RED("exploded")] public CBool Exploded { get; set; }
		[Ordinal(6)] [RED("launched")] public CBool Launched { get; set; }

		public gameweaponGrenadeReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
