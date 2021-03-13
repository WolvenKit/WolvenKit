using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFootstepDecalMaterialEntry : CVariable
	{
		[Ordinal(0)] [RED("materialTag")] public CName MaterialTag { get; set; }
		[Ordinal(1)] [RED("eventsByLocomotionState")] public CHandle<audioLocomotionStateEventDictionary> EventsByLocomotionState { get; set; }

		public audioFootstepDecalMaterialEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
