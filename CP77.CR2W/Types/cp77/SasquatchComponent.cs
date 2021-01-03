using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SasquatchComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("owner")] public wCHandle<NPCPuppet> Owner { get; set; }
		[Ordinal(1)]  [RED("owner_id")] public entEntityID Owner_id { get; set; }
		[Ordinal(2)]  [RED("statPoolSystem")] public CHandle<gameStatPoolsSystem> StatPoolSystem { get; set; }
		[Ordinal(3)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }

		public SasquatchComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
