using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCensorshipEffect : inkGlitchEffect
	{
		[Ordinal(7)] 
		[RED("censorshipFlags")] 
		public CBitField<CensorshipFlags> CensorshipFlags
		{
			get => GetPropertyValue<CBitField<CensorshipFlags>>();
			set => SetPropertyValue<CBitField<CensorshipFlags>>(value);
		}

		public inkCensorshipEffect()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
