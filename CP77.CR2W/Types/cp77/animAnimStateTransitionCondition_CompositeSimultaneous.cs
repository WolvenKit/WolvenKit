using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionCondition_CompositeSimultaneous : animIAnimStateTransitionCondition
	{
		[Ordinal(0)]  [RED("conditions")] public CArray<CHandle<animIAnimStateTransitionCondition>> Conditions { get; set; }

		public animAnimStateTransitionCondition_CompositeSimultaneous(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
