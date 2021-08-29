using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Example_FxSpawning : gameScriptableComponent
	{
		private gameFxResource _effect;
		private gameFxResource _effectBeam;

		[Ordinal(5)] 
		[RED("effect")] 
		public gameFxResource Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(6)] 
		[RED("effectBeam")] 
		public gameFxResource EffectBeam
		{
			get => GetProperty(ref _effectBeam);
			set => SetProperty(ref _effectBeam, value);
		}
	}
}
