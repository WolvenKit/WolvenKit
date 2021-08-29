using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamemappinsOutlineMappinVolume : gamemappinsIMappinVolume
	{
		private CFloat _height;
		private CArray<Vector2> _outlinePoints;

		[Ordinal(0)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(1)] 
		[RED("outlinePoints")] 
		public CArray<Vector2> OutlinePoints
		{
			get => GetProperty(ref _outlinePoints);
			set => SetProperty(ref _outlinePoints, value);
		}
	}
}
