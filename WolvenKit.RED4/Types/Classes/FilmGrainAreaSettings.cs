using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FilmGrainAreaSettings : IAreaSettings
	{
		[Ordinal(2)] 
		[RED("strength")] 
		public CLegacySingleChannelCurve<Vector4> Strength
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<Vector4>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<Vector4>>(value);
		}

		[Ordinal(3)] 
		[RED("luminanceBias")] 
		public CLegacySingleChannelCurve<CFloat> LuminanceBias
		{
			get => GetPropertyValue<CLegacySingleChannelCurve<CFloat>>();
			set => SetPropertyValue<CLegacySingleChannelCurve<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("grainSize")] 
		public Vector3 GrainSize
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(5)] 
		[RED("applyAfterUpsampling")] 
		public CBool ApplyAfterUpsampling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FilmGrainAreaSettings()
		{
			Enable = true;
			GrainSize = new Vector3 { X = 0.500000F, Y = 0.500000F, Z = 0.500000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
