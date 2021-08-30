using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsCSphereDefinition : gameinteractionsIShapeDefinition
	{
		private Vector4 _position;
		private CFloat _radius;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector4 Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(1)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		public gameinteractionsCSphereDefinition()
		{
			_radius = 1.000000F;
		}
	}
}
