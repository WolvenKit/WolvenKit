using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CFont : CResource
	{
		[RED("textures", 2,0)] 		public CArray<CHandle<CBitmapTexture>> Textures { get; set;}

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFont(cr2w, parent, name);

	}
}