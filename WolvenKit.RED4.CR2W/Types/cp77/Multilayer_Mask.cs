using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Multilayer_Mask : CResource
	{
		private rendRenderMultilayerMaskResource _renderResourceBlob;

		[Ordinal(1)] 
		[RED("renderResourceBlob")] 
		public rendRenderMultilayerMaskResource RenderResourceBlob
		{
			get => GetProperty(ref _renderResourceBlob);
			set => SetProperty(ref _renderResourceBlob, value);
		}

		public Multilayer_Mask(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
