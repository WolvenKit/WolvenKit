using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightChannelComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(9)] [RED("channels")] public CEnum<rendLightChannel> Channels { get; set; }
		[Ordinal(10)] [RED("shape")] public CHandle<GeometryShape> Shape { get; set; }

		public entLightChannelComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
