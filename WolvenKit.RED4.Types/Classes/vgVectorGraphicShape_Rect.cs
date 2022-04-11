using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vgVectorGraphicShape_Rect : vgBaseVectorGraphicShape
	{
		[Ordinal(2)] 
		[RED("mensions")] 
		public Vector2 Mensions
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		public vgVectorGraphicShape_Rect()
		{
			CalTransform = new();
			Mensions = new();
		}
	}
}
