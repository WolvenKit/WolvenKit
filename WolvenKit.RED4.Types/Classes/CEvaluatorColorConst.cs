using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorColorConst : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CColor Value
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public CEvaluatorColorConst()
		{
			Value = new();
		}
	}
}
