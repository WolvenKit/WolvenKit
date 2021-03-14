using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLightChannelShapeNode : worldGeometryShapeNode
	{
		[Ordinal(6)] [RED("channels")] public CEnum<rendLightChannel> Channels { get; set; }
		[Ordinal(7)] [RED("streamingDistanceFactor")] public CFloat StreamingDistanceFactor { get; set; }

		public worldLightChannelShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
