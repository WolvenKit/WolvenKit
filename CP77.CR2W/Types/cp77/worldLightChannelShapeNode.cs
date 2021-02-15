using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldLightChannelShapeNode : worldGeometryShapeNode
	{
		[Ordinal(4)] [RED("channels")] public CEnum<rendLightChannel> Channels { get; set; }
		[Ordinal(5)] [RED("streamingDistanceFactor")] public CFloat StreamingDistanceFactor { get; set; }

		public worldLightChannelShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
