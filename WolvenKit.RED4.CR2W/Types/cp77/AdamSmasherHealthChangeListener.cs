using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(1)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(2)] [RED("adamSmasherComponent")] public CHandle<AdamSmasherComponent> AdamSmasherComponent { get; set; }
		[Ordinal(3)] [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(4)] [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }

		public AdamSmasherHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
