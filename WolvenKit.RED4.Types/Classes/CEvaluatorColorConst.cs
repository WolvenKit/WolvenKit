using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorColorConst : IEvaluatorColor
	{
		private CColor _value;

		[Ordinal(0)] 
		[RED("value")] 
		public CColor Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
