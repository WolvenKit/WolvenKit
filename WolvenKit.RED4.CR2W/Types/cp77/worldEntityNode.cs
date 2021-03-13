using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEntityNode : worldNode
	{
		[Ordinal(4)] [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
		[Ordinal(5)] [RED("instanceData")] public CHandle<entEntityInstanceData> InstanceData { get; set; }
		[Ordinal(6)] [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(7)] [RED("ioPriority")] public CEnum<entEntitySpawnPriority> IoPriority { get; set; }
		[Ordinal(8)] [RED("entityLod")] public CUInt16 EntityLod { get; set; }

		public worldEntityNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
