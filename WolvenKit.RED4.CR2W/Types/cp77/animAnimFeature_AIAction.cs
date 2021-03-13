using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_AIAction : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(2)] [RED("stateDuration")] public CFloat StateDuration { get; set; }
		[Ordinal(3)] [RED("direction")] public CFloat Direction { get; set; }

		public animAnimFeature_AIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
