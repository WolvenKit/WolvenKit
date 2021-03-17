using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
	{
		private CArray<Vector2> _ints;
		private CFloat _roke;

		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get => GetProperty(ref _ints);
			set => SetProperty(ref _ints, value);
		}

		[Ordinal(3)] 
		[RED("roke")] 
		public CFloat Roke
		{
			get => GetProperty(ref _roke);
			set => SetProperty(ref _roke, value);
		}

		public vgVectorGraphicShape_PolyLine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
