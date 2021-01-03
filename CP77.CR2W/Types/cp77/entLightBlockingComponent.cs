using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entLightBlockingComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("lightBlockerComponentVersion")] public CUInt8 LightBlockerComponentVersion { get; set; }
		[Ordinal(1)]  [RED("radius")] public CFloat Radius { get; set; }

		public entLightBlockingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
