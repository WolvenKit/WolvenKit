using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitShape_OBB : gameHitShapeBase
	{
		private Vector3 _dimensions;

		[Ordinal(3)] 
		[RED("dimensions")] 
		public Vector3 Dimensions
		{
			get => GetProperty(ref _dimensions);
			set => SetProperty(ref _dimensions, value);
		}
	}
}
