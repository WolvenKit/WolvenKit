using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CLayerInfo : ISerializable
	{
		[RED("tags")] 		public TagList Tags { get; set;}

		[RED("layerType")] 		public CEnum<ELayerType> LayerType { get; set;}

		[RED("layerBuildTag")] 		public CEnum<ELayerBuildTag> LayerBuildTag { get; set;}

		[RED("layerMergeContentMode")] 		public CEnum<ELayerMergedContent> LayerMergeContentMode { get; set;}

		[RED("streamingLayer")] 		public CBool StreamingLayer { get; set;}

		[RED("depotFilePath")] 		public CString DepotFilePath { get; set;}

		[RED("shortName")] 		public CString ShortName { get; set;}

		[RED("guid")] 		public CGUID Guid { get; set;}

		[RED("hasEmbeddedLayerInfo")] 		public CBool HasEmbeddedLayerInfo { get; set;}

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayerInfo(cr2w, parent, name);

	}
}