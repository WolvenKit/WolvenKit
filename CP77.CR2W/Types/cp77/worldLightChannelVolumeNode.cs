using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldLightChannelVolumeNode : worldAreaShapeNode
	{
		[Ordinal(0)]  [RED("channels")] public CEnum<rendLightChannel> Channels { get; set; }
		[Ordinal(1)]  [RED("streamingDistanceFactor")] public CFloat StreamingDistanceFactor { get; set; }

		public worldLightChannelVolumeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
