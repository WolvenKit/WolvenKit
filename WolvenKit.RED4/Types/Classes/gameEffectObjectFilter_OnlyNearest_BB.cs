using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectObjectFilter_OnlyNearest_BB : gameEffectObjectFilter_OnlyNearest
	{
		[Ordinal(1)] 
		[RED("parameter")] 
		public gameEffectInputParameter_Int Parameter
		{
			get => GetPropertyValue<gameEffectInputParameter_Int>();
			set => SetPropertyValue<gameEffectInputParameter_Int>(value);
		}

		public gameEffectObjectFilter_OnlyNearest_BB()
		{
			Parameter = new gameEffectInputParameter_Int();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
