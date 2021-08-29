using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkDrawArea : RedBaseClass
	{
		private Vector2 _size;
		private CFloat _scale;
		private Vector2 _relativePosition;
		private Vector2 _absolutePosition;

		[Ordinal(0)] 
		[RED("size")] 
		public Vector2 Size
		{
			get => GetProperty(ref _size);
			set => SetProperty(ref _size, value);
		}

		[Ordinal(1)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(2)] 
		[RED("relativePosition")] 
		public Vector2 RelativePosition
		{
			get => GetProperty(ref _relativePosition);
			set => SetProperty(ref _relativePosition, value);
		}

		[Ordinal(3)] 
		[RED("absolutePosition")] 
		public Vector2 AbsolutePosition
		{
			get => GetProperty(ref _absolutePosition);
			set => SetProperty(ref _absolutePosition, value);
		}
	}
}
