using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleModificatorNoise : IParticleModificator
	{
		[Ordinal(4)] 
		[RED("amplitude")] 
		public CHandle<IEvaluatorVector> Amplitude
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(5)] 
		[RED("offset")] 
		public CHandle<IEvaluatorVector> Offset
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CHandle<IEvaluatorVector> Frequency
		{
			get => GetPropertyValue<CHandle<IEvaluatorVector>>();
			set => SetPropertyValue<CHandle<IEvaluatorVector>>(value);
		}

		[Ordinal(7)] 
		[RED("changeRate")] 
		public Vector3 ChangeRate
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("applyToPosition")] 
		public CBool ApplyToPosition
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("worldSpaceOffset")] 
		public CBool WorldSpaceOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("noiseType")] 
		public CEnum<ENoiseType> NoiseType
		{
			get => GetPropertyValue<CEnum<ENoiseType>>();
			set => SetPropertyValue<CEnum<ENoiseType>>(value);
		}

		public CParticleModificatorNoise()
		{
			EditorName = "Noise";
			EditorGroup = "Position";
			IsEnabled = true;
			Amplitude = new CEvaluatorVectorConst { Value = new Vector4 { X = 4.000000F, Y = 4.000000F, Z = 4.000000F, W = 1.000000F } };
			Offset = new CEvaluatorVectorConst { Value = new Vector4 { W = 1.000000F } };
			Frequency = new CEvaluatorVectorConst { Value = new Vector4 { X = 6.000000F, Y = 6.000000F, Z = 6.000000F, W = 1.000000F } };
			ChangeRate = new Vector3 { X = 1.000000F, Y = 1.000000F, Z = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
