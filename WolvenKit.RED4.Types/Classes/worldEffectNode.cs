using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldEffectNode : worldNode
	{
		private CResourceAsyncReference<worldEffect> _effect;
		private CFloat _streamingDistanceOverride;

		[Ordinal(4)] 
		[RED("effect")] 
		public CResourceAsyncReference<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(5)] 
		[RED("streamingDistanceOverride")] 
		public CFloat StreamingDistanceOverride
		{
			get => GetProperty(ref _streamingDistanceOverride);
			set => SetProperty(ref _streamingDistanceOverride, value);
		}
	}
}
