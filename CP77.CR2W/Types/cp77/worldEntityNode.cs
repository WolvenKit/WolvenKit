using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldEntityNode : worldNode
	{
		[Ordinal(0)]  [RED("appearanceName")] public CName AppearanceName { get; set; }
		[Ordinal(1)]  [RED("entityLod")] public CUInt16 EntityLod { get; set; }
		[Ordinal(2)]  [RED("entityTemplate")] public raRef<entEntityTemplate> EntityTemplate { get; set; }
		[Ordinal(3)]  [RED("instanceData")] public CHandle<entEntityInstanceData> InstanceData { get; set; }
		[Ordinal(4)]  [RED("ioPriority")] public CEnum<entEntitySpawnPriority> IoPriority { get; set; }

		public worldEntityNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
