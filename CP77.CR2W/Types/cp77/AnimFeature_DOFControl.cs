using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DOFControl : animAnimFeature
	{
		[Ordinal(0)]  [RED("dofBlendInTime")] public CFloat DofBlendInTime { get; set; }
		[Ordinal(1)]  [RED("dofBlendOutTime")] public CFloat DofBlendOutTime { get; set; }
		[Ordinal(2)]  [RED("dofFarBlur")] public CFloat DofFarBlur { get; set; }
		[Ordinal(3)]  [RED("dofFarFocus")] public CFloat DofFarFocus { get; set; }
		[Ordinal(4)]  [RED("dofIntensity")] public CFloat DofIntensity { get; set; }
		[Ordinal(5)]  [RED("dofNearBlur")] public CFloat DofNearBlur { get; set; }
		[Ordinal(6)]  [RED("dofNearFocus")] public CFloat DofNearFocus { get; set; }

		public AnimFeature_DOFControl(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
