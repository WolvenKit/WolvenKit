using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_DirectConnConstraint : animAnimNode_OnePoseInput
	{
		private CHandle<animIAnimNodeSourceChannel_QsTransform> _sourceTransform;
		private CBool _isSourceTransformResaved;
		private animTransformIndex _sourceTransformIndex;
		private animTransformIndex _transformIndex;
		private CBool _posX;
		private CBool _posY;
		private CBool _posZ;
		private CBool _rotX;
		private CBool _rotY;
		private CBool _rotZ;
		private CBool _scaleX;
		private CBool _scaleY;
		private CBool _scaleZ;
		private CFloat _weight;
		private animFloatLink _weightNode;

		[Ordinal(12)] 
		[RED("sourceTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> SourceTransform
		{
			get => GetProperty(ref _sourceTransform);
			set => SetProperty(ref _sourceTransform, value);
		}

		[Ordinal(13)] 
		[RED("isSourceTransformResaved")] 
		public CBool IsSourceTransformResaved
		{
			get => GetProperty(ref _isSourceTransformResaved);
			set => SetProperty(ref _isSourceTransformResaved, value);
		}

		[Ordinal(14)] 
		[RED("sourceTransformIndex")] 
		public animTransformIndex SourceTransformIndex
		{
			get => GetProperty(ref _sourceTransformIndex);
			set => SetProperty(ref _sourceTransformIndex, value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(16)] 
		[RED("posX")] 
		public CBool PosX
		{
			get => GetProperty(ref _posX);
			set => SetProperty(ref _posX, value);
		}

		[Ordinal(17)] 
		[RED("posY")] 
		public CBool PosY
		{
			get => GetProperty(ref _posY);
			set => SetProperty(ref _posY, value);
		}

		[Ordinal(18)] 
		[RED("posZ")] 
		public CBool PosZ
		{
			get => GetProperty(ref _posZ);
			set => SetProperty(ref _posZ, value);
		}

		[Ordinal(19)] 
		[RED("rotX")] 
		public CBool RotX
		{
			get => GetProperty(ref _rotX);
			set => SetProperty(ref _rotX, value);
		}

		[Ordinal(20)] 
		[RED("rotY")] 
		public CBool RotY
		{
			get => GetProperty(ref _rotY);
			set => SetProperty(ref _rotY, value);
		}

		[Ordinal(21)] 
		[RED("rotZ")] 
		public CBool RotZ
		{
			get => GetProperty(ref _rotZ);
			set => SetProperty(ref _rotZ, value);
		}

		[Ordinal(22)] 
		[RED("scaleX")] 
		public CBool ScaleX
		{
			get => GetProperty(ref _scaleX);
			set => SetProperty(ref _scaleX, value);
		}

		[Ordinal(23)] 
		[RED("scaleY")] 
		public CBool ScaleY
		{
			get => GetProperty(ref _scaleY);
			set => SetProperty(ref _scaleY, value);
		}

		[Ordinal(24)] 
		[RED("scaleZ")] 
		public CBool ScaleZ
		{
			get => GetProperty(ref _scaleZ);
			set => SetProperty(ref _scaleZ, value);
		}

		[Ordinal(25)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(26)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		public animAnimNode_DirectConnConstraint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
