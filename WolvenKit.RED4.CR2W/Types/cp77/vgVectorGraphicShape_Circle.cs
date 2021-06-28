using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Circle : vgBaseVectorGraphicShape
	{
		private CFloat _dius;

		[Ordinal(2)] 
		[RED("dius")] 
		public CFloat Dius
		{
			get => GetProperty(ref _dius);
			set => SetProperty(ref _dius, value);
		}

		public vgVectorGraphicShape_Circle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
