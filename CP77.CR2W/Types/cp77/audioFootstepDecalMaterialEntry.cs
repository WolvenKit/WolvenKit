using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialEntry : CVariable
	{
		[Ordinal(0)]  [RED("eventsByLocomotionState")] public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState { get; set; }
		[Ordinal(1)]  [RED("materialTag")] public CName MaterialTag { get; set; }

		public audioFootstepDecalMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
