using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CEntity : CNode
	{
		//[Ordinal(1)] [RED("components", 2,0)] 		public CArray<CPtr<CComponent>> Components { get; set;}

		[Ordinal(2)] [RED("template")] 		public CHandle<CEntityTemplate> Template { get; set;}

		[Ordinal(3)] [RED("streamingDataBuffer")] 		public SharedDataBuffer StreamingDataBuffer { get; set;}

		[Ordinal(4)] [RED("streamingDistance")] 		public CUInt8 StreamingDistance { get; set;}

		[Ordinal(5)] [RED("entityStaticFlags")] 		public CEnum<EEntityStaticFlags> EntityStaticFlags { get; set;}

		[Ordinal(6)] [RED("autoPlayEffectName")] 		public CName AutoPlayEffectName { get; set;}

		[Ordinal(7)] [RED("entityFlags")] 		public CUInt8 EntityFlags { get; set;}

		[Ordinal(8)] [RED("name")] 		public CString Name { get; set;}

		[Ordinal(9)] [RED("forceAutoHideDistance")] 		public CUInt16 ForceAutoHideDistance { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEntity(cr2w, parent, name);

	}
}