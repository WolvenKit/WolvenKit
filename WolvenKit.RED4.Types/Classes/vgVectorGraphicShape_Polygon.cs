using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Polygon : vgBaseVectorGraphicShape
	{
		private CArray<Vector2> _ints;

		[Ordinal(2)] 
		[RED("ints")] 
		public CArray<Vector2> Ints
		{
			get => GetProperty(ref _ints);
			set => SetProperty(ref _ints, value);
		}
	}
}
