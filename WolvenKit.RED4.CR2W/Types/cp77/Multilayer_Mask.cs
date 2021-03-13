using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Mask : CResource
	{
		[Ordinal(1)] [RED("renderResourceBlob")] public rendRenderMultilayerMaskResource RenderResourceBlob { get; set; }

		public Multilayer_Mask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
