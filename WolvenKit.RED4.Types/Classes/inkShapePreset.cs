using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkShapePreset : RedBaseClass
	{
		private CName _name;
		private CArray<Vector2> _points;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("points")] 
		public CArray<Vector2> Points
		{
			get => GetProperty(ref _points);
			set => SetProperty(ref _points, value);
		}
	}
}
