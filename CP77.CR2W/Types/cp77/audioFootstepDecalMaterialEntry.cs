using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialEntry : CVariable
	{
		[Ordinal(0)]  [RED("eventsByLocomotionState")] public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState { get; set; }
		[Ordinal(1)]  [RED("materialTag")] public CName MaterialTag { get; set; }

		public audioFootstepDecalMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
