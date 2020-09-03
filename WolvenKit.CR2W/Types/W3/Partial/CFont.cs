using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CFont : CResource
	{
		[Ordinal(1)] [RED("textures", 2,0)] 		public CArray<CHandle<CBitmapTexture>> Textures { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFont(cr2w, parent, name);

	}
}