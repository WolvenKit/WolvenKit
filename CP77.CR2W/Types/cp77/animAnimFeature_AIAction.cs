using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_AIAction : animAnimFeature
	{
		[Ordinal(0)]  [RED("animVariation")] public CInt32 AnimVariation { get; set; }
		[Ordinal(1)]  [RED("direction")] public CFloat Direction { get; set; }
		[Ordinal(2)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(3)]  [RED("stateDuration")] public CFloat StateDuration { get; set; }

		public animAnimFeature_AIAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
