using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_MultipleParentConstraint_ParentInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("parentWeightMode")] 
		public CEnum<animConstraintWeightMode> ParentWeightMode
		{
			get => GetPropertyValue<CEnum<animConstraintWeightMode>>();
			set => SetPropertyValue<CEnum<animConstraintWeightMode>>(value);
		}

		[Ordinal(2)] 
		[RED("parentStaticWeight")] 
		public CFloat ParentStaticWeight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("parentTrackWeight")] 
		public animNamedTrackIndex ParentTrackWeight
		{
			get => GetPropertyValue<animNamedTrackIndex>();
			set => SetPropertyValue<animNamedTrackIndex>(value);
		}

		[Ordinal(4)] 
		[RED("useComplementWeight")] 
		public CBool UseComplementWeight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("useOffset")] 
		public CBool UseOffset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("offset")] 
		public QsTransform Offset
		{
			get => GetPropertyValue<QsTransform>();
			set => SetPropertyValue<QsTransform>(value);
		}

		public animAnimNode_MultipleParentConstraint_ParentInfo()
		{
			ParentTransform = new();
			ParentStaticWeight = 1.000000F;
			ParentTrackWeight = new();
			Offset = new() { Translation = new() { W = 1.000000F }, Rotation = new() { R = 1.000000F }, Scale = new() { X = 1.000000F, Y = 1.000000F, Z = 1.000000F, W = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
