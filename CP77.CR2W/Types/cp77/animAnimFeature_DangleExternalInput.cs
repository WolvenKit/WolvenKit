using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_DangleExternalInput : animAnimFeature
	{
		[Ordinal(0)]  [RED("fictitiousAccelerationWs")] public Vector4 FictitiousAccelerationWs { get; set; }

		public animAnimFeature_DangleExternalInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
