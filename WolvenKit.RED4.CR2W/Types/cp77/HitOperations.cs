using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitOperations : DeviceOperations
	{
		[Ordinal(2)] [RED("hitOperations")] public CArray<SHitOperationData> HitOperations_ { get; set; }

		public HitOperations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
