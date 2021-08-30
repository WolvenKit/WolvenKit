using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldRaceSplineNode : worldSpeedSplineNode
	{
		private CArray<worldRaceSplineNodeOffset> _offsets;
		private CFloat _offsetDefault;

		[Ordinal(17)] 
		[RED("offsets")] 
		public CArray<worldRaceSplineNodeOffset> Offsets
		{
			get => GetProperty(ref _offsets);
			set => SetProperty(ref _offsets, value);
		}

		[Ordinal(18)] 
		[RED("offsetDefault")] 
		public CFloat OffsetDefault
		{
			get => GetProperty(ref _offsetDefault);
			set => SetProperty(ref _offsetDefault, value);
		}

		public worldRaceSplineNode()
		{
			_offsetDefault = 5.000000F;
		}
	}
}
