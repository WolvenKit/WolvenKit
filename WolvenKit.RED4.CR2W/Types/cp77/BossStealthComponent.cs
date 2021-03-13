using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossStealthComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(6)] [RED("owner_id")] public entEntityID Owner_id { get; set; }
		[Ordinal(7)] [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(8)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(9)] [RED("targetTrackerComponent")] public CHandle<AITargetTrackerComponent> TargetTrackerComponent { get; set; }

		public BossStealthComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
