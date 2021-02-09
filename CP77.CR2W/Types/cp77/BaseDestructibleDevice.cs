using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BaseDestructibleDevice : Device
	{
		[Ordinal(77)]  [RED("minTime")] public CFloat MinTime { get; set; }
		[Ordinal(78)]  [RED("maxTime")] public CFloat MaxTime { get; set; }
		[Ordinal(79)]  [RED("destroyedMesh")] public CHandle<entPhysicalMeshComponent> DestroyedMesh { get; set; }

		public BaseDestructibleDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
