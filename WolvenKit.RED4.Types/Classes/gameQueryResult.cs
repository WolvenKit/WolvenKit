using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameQueryResult : RedBaseClass
	{
		private CArray<gameShapeData> _hitShapes;

		[Ordinal(0)] 
		[RED("hitShapes")] 
		public CArray<gameShapeData> HitShapes
		{
			get => GetProperty(ref _hitShapes);
			set => SetProperty(ref _hitShapes, value);
		}
	}
}
