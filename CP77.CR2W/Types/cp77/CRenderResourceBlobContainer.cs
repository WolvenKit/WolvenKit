using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CRenderResourceBlobContainer : ISerializable
	{
		[Ordinal(0)]  [RED("blob")] public CHandle<IRenderResourceBlob> Blob { get; set; }

		public CRenderResourceBlobContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
