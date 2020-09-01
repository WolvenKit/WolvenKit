using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CEntity : CNode
	{
		[Ordinal(0)] [RED("components", 2,0)] 		public CArray<CPtr<CComponent>> Components { get; set;}

		[Ordinal(0)] [RED("template")] 		public CHandle<CEntityTemplate> Template { get; set;}

		[Ordinal(0)] [RED("streamingDataBuffer")] 		public SharedDataBuffer StreamingDataBuffer { get; set;}

		[Ordinal(0)] [RED("streamingDistance")] 		public CUInt8 StreamingDistance { get; set;}

		[Ordinal(0)] [RED("entityStaticFlags")] 		public EEntityStaticFlags EntityStaticFlags { get; set;}

		[Ordinal(0)] [RED("autoPlayEffectName")] 		public CName AutoPlayEffectName { get; set;}

		[Ordinal(0)] [RED("entityFlags")] 		public CUInt8 EntityFlags { get; set;}

		[Ordinal(0)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(0)] [RED("forceAutoHideDistance")] 		public CUInt16 ForceAutoHideDistance { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntity(cr2w, parent, name);

	}
}