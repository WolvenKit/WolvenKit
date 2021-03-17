using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SvgResource : CResource
	{
		private CHandle<vgVectorGraphicDefinition> _vectorGraphicDef;

		[Ordinal(1)] 
		[RED("vectorGraphicDef")] 
		public CHandle<vgVectorGraphicDefinition> VectorGraphicDef
		{
			get => GetProperty(ref _vectorGraphicDef);
			set => SetProperty(ref _vectorGraphicDef, value);
		}

		public SvgResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
