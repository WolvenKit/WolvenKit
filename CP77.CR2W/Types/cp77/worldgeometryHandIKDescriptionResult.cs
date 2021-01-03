using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldgeometryHandIKDescriptionResult : CVariable
	{
		[Ordinal(0)]  [RED("grabPointEnd")] public Vector4 GrabPointEnd { get; set; }
		[Ordinal(1)]  [RED("grabPointStart")] public Vector4 GrabPointStart { get; set; }

		public worldgeometryHandIKDescriptionResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
