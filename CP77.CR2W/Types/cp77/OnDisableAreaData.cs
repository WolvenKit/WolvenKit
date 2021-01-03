using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class OnDisableAreaData : CVariable
	{
		[Ordinal(0)]  [RED("agent")] public gamePersistentID Agent { get; set; }
		[Ordinal(1)]  [RED("remainingAreas")] public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas { get; set; }

		public OnDisableAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
