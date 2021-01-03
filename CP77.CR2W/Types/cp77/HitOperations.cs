using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HitOperations : DeviceOperations
	{
		[Ordinal(0)]  [RED("hitOperations")] public CArray<SHitOperationData> HitOperations { get; set; }

		public HitOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
