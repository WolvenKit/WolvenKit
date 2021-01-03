using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entLightChannelComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("channels")] public rendLightChannel Channels { get; set; }
		[Ordinal(1)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(2)]  [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }

		public entLightChannelComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
