using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CLayerInfo : ISerializable
	{
		[Ordinal(1)] [RED("tags")] 		public TagList Tags { get; set;}

		[Ordinal(2)] [RED("layerType")] 		public CEnum<ELayerType> LayerType { get; set;}

		[Ordinal(3)] [RED("layerBuildTag")] 		public CEnum<ELayerBuildTag> LayerBuildTag { get; set;}

		[Ordinal(4)] [RED("layerMergeContentMode")] 		public CEnum<ELayerMergedContent> LayerMergeContentMode { get; set;}

		[Ordinal(5)] [RED("streamingLayer")] 		public CBool StreamingLayer { get; set;}

		[Ordinal(6)] [RED("depotFilePath")] 		public CString DepotFilePath { get; set;}

		[Ordinal(7)] [RED("shortName")] 		public CString ShortName { get; set;}

		[Ordinal(8)] [RED("guid")] 		public CGUID Guid { get; set;}

		[Ordinal(9)] [RED("hasEmbeddedLayerInfo")] 		public CBool HasEmbeddedLayerInfo { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CLayerInfo(cr2w, parent, name);

	}
}