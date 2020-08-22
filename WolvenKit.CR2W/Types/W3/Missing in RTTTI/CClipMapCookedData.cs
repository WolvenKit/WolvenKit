using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta(EREDMetaInfo.REDStruct)]
	public partial class CClipMapCookedData : ISerializable
	{

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CClipMapCookedData(cr2w, parent, name);

		

	}
}