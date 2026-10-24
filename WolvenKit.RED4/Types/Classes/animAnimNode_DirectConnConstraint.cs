using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(2)] 
		[RED("sourceTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>(value);
		}

		[Ordinal(3)] 
		[RED("isSourceTransformResaved")] 
		public CBool IsSourceTransformResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("sourceTransformIndex")] 
		public animTransformIndex SourceTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(5)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(6)] 
		[RED("posX")] 
		public CBool PosX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("posY")] 
		public CBool PosY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("posZ")] 
		public CBool PosZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("rotX")] 
		public CBool RotX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("rotY")] 
		public CBool RotY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("rotZ")] 
		public CBool RotZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("scaleY")] 
		public CBool ScaleY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("scaleZ")] 
		public CBool ScaleZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_DirectConnConstraint()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();
			SourceTransformIndex = new animTransformIndex();
			TransformIndex = new animTransformIndex();
			Weight = 1.000000F;
			WeightNode = new animFloatLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
