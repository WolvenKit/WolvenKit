using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("sourceTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform
		{
			get => GetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>();
			set => SetPropertyValue<CHandle<animIAnimNodeSourceChannel_QsTransform>>(value);
		}

		[Ordinal(13)] 
		[RED("isSourceTransformResaved")] 
		public CBool IsSourceTransformResaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("sourceTransformIndex")] 
		public animTransformIndex SourceTransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(16)] 
		[RED("posX")] 
		public CBool PosX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("posY")] 
		public CBool PosY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("posZ")] 
		public CBool PosZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("rotX")] 
		public CBool RotX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("rotY")] 
		public CBool RotY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("rotZ")] 
		public CBool RotZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("scaleY")] 
		public CBool ScaleY
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("scaleZ")] 
		public CBool ScaleZ
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_DirectConnConstraint()
		{
			Id = 4294967295;
			InputLink = new();
			SourceTransformIndex = new();
			TransformIndex = new();
			Weight = 1.000000F;
			WeightNode = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
