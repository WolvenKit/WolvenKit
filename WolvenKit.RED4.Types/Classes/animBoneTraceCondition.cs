using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animBoneTraceCondition : ISerializable
	{
		[Ordinal(0)] 
		[RED("boneIndex")] 
		public CInt16 BoneIndex
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(1)] 
		[RED("traceByRotation")] 
		public CBool TraceByRotation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("rotationAngleTolerance")] 
		public CFloat RotationAngleTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("traceByTranslation")] 
		public CBool TraceByTranslation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("translationTolerance")] 
		public CFloat TranslationTolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animBoneTraceCondition()
		{
			BoneIndex = -1;
			TraceByRotation = true;
			RotationAngleTolerance = 0.785398F;
			TraceByTranslation = true;
			TranslationTolerance = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
