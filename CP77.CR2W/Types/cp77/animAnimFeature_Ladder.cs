using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Ladder : animAnimFeature
	{
		[Ordinal(0)]  [RED("distanceFromTop")] public CFloat DistanceFromTop { get; set; }
		[Ordinal(1)]  [RED("entryFromRight")] public CBool EntryFromRight { get; set; }
		[Ordinal(2)]  [RED("state")] public CInt32 State { get; set; }
		[Ordinal(3)]  [RED("transitionType")] public CInt32 TransitionType { get; set; }

		public animAnimFeature_Ladder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
