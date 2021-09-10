using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Example_FxSpawning : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}

		[Ordinal(6)] 
		[RED("effectBeam")] 
		public gameFxResource EffectBeam
		{
			get => GetPropertyValue<gameFxResource>();
			set => SetPropertyValue<gameFxResource>(value);
		}
	}
}
