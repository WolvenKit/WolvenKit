using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CFont : CResource
	{
		[Ordinal(1)] [RED("textures", 2,0)] 		public CArray<CHandle<CBitmapTexture>> Textures { get; set;}


	}
}
