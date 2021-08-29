using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Rect : vgBaseVectorGraphicShape
	{
		private Vector2 _mensions;

		[Ordinal(2)] 
		[RED("mensions")] 
		public Vector2 Mensions
		{
			get => GetProperty(ref _mensions);
			set => SetProperty(ref _mensions, value);
		}
	}
}
