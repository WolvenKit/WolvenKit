using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FilmGrainAreaSettings : IAreaSettings
	{
		private CLegacySingleChannelCurve<Vector4> _strength;
		private CLegacySingleChannelCurve<CFloat> _luminanceBias;
		private Vector3 _grainSize;
		private CBool _applyAfterUpsampling;

		[Ordinal(2)] 
		[RED("strength")] 
		public CLegacySingleChannelCurve<Vector4> Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(3)] 
		[RED("luminanceBias")] 
		public CLegacySingleChannelCurve<CFloat> LuminanceBias
		{
			get => GetProperty(ref _luminanceBias);
			set => SetProperty(ref _luminanceBias, value);
		}

		[Ordinal(4)] 
		[RED("grainSize")] 
		public Vector3 GrainSize
		{
			get => GetProperty(ref _grainSize);
			set => SetProperty(ref _grainSize, value);
		}

		[Ordinal(5)] 
		[RED("applyAfterUpsampling")] 
		public CBool ApplyAfterUpsampling
		{
			get => GetProperty(ref _applyAfterUpsampling);
			set => SetProperty(ref _applyAfterUpsampling, value);
		}
	}
}
