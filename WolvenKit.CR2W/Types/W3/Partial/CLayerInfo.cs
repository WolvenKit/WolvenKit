using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CLayerInfo : ISerializable
	{
		[Ordinal(0)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(0)] [RED("layerType")] 		public CEnum<ELayerType> LayerType { get; set;}

		[Ordinal(0)] [RED("layerBuildTag")] 		public CEnum<ELayerBuildTag> LayerBuildTag { get; set;}

		[Ordinal(0)] [RED("layerMergeContentMode")] 		public CEnum<ELayerMergedContent> LayerMergeContentMode { get; set;}

		[Ordinal(0)] [RED("streamingLayer")] 		public CBool StreamingLayer { get; set;}

		[Ordinal(0)] [RED("depotFilePath")] 		public CString DepotFilePath { get; set;}

		[Ordinal(0)] [RED("shortName")] 		public CString ShortName { get; set;}

		[Ordinal(0)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(0)] [RED("hasEmbeddedLayerInfo")] 		public CBool HasEmbeddedLayerInfo { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayerInfo(cr2w, parent, name);

	}
}