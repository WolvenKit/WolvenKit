using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class meshMeshParamOccluderData : meshMeshParameter
	{
		[Ordinal(0)]  [RED("autoHideDistanceScale")] public CUInt8 AutoHideDistanceScale { get; set; }
		[Ordinal(1)]  [RED("defaultOccluderType")] public CEnum<visWorldOccluderType> DefaultOccluderType { get; set; }
		[Ordinal(2)]  [RED("occluderResource")] public CHandle<visIOccluderResource> OccluderResource { get; set; }

		public meshMeshParamOccluderData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
