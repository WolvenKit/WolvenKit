using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkLayersResource : CResource
	{
		[Ordinal(0)]  [RED("layerDefinitions")] public inkLayerDefinitionCollection LayerDefinitions { get; set; }
		[Ordinal(1)]  [RED("permanentLayerDefinitions")] public inkPermanentLayerDefinitionCollection PermanentLayerDefinitions { get; set; }
		[Ordinal(2)]  [RED("preGameLayerDefinitions")] public inkLayerDefinitionCollection PreGameLayerDefinitions { get; set; }

		public inkLayersResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
