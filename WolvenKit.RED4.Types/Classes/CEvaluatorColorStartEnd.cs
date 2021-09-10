using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorColorStartEnd : IEvaluatorColor
	{
		[Ordinal(0)] 
		[RED("start")] 
		public CColor Start
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CColor End
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public CEvaluatorColorStartEnd()
		{
			Start = new();
			End = new();
		}
	}
}
