using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldNavigationScriptCostModCircle : IScriptable
	{
		private Vector4 _pos;
		private CFloat _range;
		private CFloat _cost;

		[Ordinal(0)] 
		[RED("pos")] 
		public Vector4 Pos
		{
			get => GetProperty(ref _pos);
			set => SetProperty(ref _pos, value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetProperty(ref _range);
			set => SetProperty(ref _range, value);
		}

		[Ordinal(2)] 
		[RED("cost")] 
		public CFloat Cost
		{
			get => GetProperty(ref _cost);
			set => SetProperty(ref _cost, value);
		}

		public worldNavigationScriptCostModCircle()
		{
			_cost = 1.000000F;
		}
	}
}
