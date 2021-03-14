using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifyFootstepMaterialContextChanged : redEvent
	{
		[Ordinal(0)] [RED("footwareType")] public CName FootwareType { get; set; }
		[Ordinal(1)] [RED("surfaceFlavourName")] public CName SurfaceFlavourName { get; set; }

		public gameaudioeventsNotifyFootstepMaterialContextChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
