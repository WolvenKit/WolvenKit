using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialParameterColor : CMaterialParameter
	{
		[Ordinal(2)] 
		[RED("color")] 
		public CColor Color
		{
			get => GetPropertyValue<CColor>();
			set => SetPropertyValue<CColor>(value);
		}

		public CMaterialParameterColor()
		{
			Color = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
