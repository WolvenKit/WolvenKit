using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightBlockingComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(9)] [RED("lightBlockerComponentVersion")] public CUInt8 LightBlockerComponentVersion { get; set; }

		public entLightBlockingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
