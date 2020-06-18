using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CGenericGrassMask : CResource
	{
		[RED("maskRes")] 		public CUInt32 MaskRes { get; set;}


		public override CVariable Create(CR2WFile cr2w) => new CGenericGrassMask(cr2w);

	}
}