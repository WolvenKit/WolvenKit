using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendHistogramBias : RedBaseClass
	{
		private Vector3 _mulCoef;
		private Vector3 _addCoef;

		[Ordinal(0)] 
		[RED("mulCoef")] 
		public Vector3 MulCoef
		{
			get => GetProperty(ref _mulCoef);
			set => SetProperty(ref _mulCoef, value);
		}

		[Ordinal(1)] 
		[RED("addCoef")] 
		public Vector3 AddCoef
		{
			get => GetProperty(ref _addCoef);
			set => SetProperty(ref _addCoef, value);
		}
	}
}
