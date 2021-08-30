using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameHitShape_Sphere : gameHitShapeBase
	{
		private CFloat _radius;

		[Ordinal(3)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		public gameHitShape_Sphere()
		{
			_radius = 0.200000F;
		}
	}
}
