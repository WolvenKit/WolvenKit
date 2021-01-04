using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AdamSmasherHealthChangeListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)]  [RED("adamSmasherComponent")] public CHandle<AdamSmasherComponent> AdamSmasherComponent { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(2)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(3)]  [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(4)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public AdamSmasherHealthChangeListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
