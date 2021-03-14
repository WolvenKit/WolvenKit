using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnDisableAreaData : CVariable
	{
		[Ordinal(0)] [RED("agent")] public gamePersistentID Agent { get; set; }
		[Ordinal(1)] [RED("remainingAreas")] public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas { get; set; }

		public OnDisableAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
