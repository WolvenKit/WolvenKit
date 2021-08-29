using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Segment : RedBaseClass
	{
		private Vector4 _origin;
		private Vector4 _direction;

		[Ordinal(0)] 
		[RED("origin")] 
		public Vector4 Origin
		{
			get => GetProperty(ref _origin);
			set => SetProperty(ref _origin, value);
		}

		[Ordinal(1)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}
	}
}
