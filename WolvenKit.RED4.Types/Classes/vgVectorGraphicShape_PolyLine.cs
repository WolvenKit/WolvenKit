using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_PolyLine : vgBaseVectorGraphicShape
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
	}
}
