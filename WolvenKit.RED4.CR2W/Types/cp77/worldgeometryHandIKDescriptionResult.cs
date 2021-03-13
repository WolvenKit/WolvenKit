using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldgeometryHandIKDescriptionResult : CVariable
	{
		[Ordinal(0)] [RED("grabPointStart")] public Vector4 GrabPointStart { get; set; }
		[Ordinal(1)] [RED("grabPointEnd")] public Vector4 GrabPointEnd { get; set; }

		public worldgeometryHandIKDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
