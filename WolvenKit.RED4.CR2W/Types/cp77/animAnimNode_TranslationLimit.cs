using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TranslationLimit : animAnimNode_OnePoseInput
	{
		private animTransformIndex _constrainedTransform;
		private animTransformIndex _parentTransform;
		private animFloatClamp _limitOnXAxis;
		private animFloatClamp _limitOnYAxis;
		private animFloatClamp _limitOnZAxis;

		[Ordinal(12)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(13)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}

		[Ordinal(14)] 
		[RED("limitOnXAxis")] 
		public animFloatClamp LimitOnXAxis
		{
			get => GetProperty(ref _limitOnXAxis);
			set => SetProperty(ref _limitOnXAxis, value);
		}

		[Ordinal(15)] 
		[RED("limitOnYAxis")] 
		public animFloatClamp LimitOnYAxis
		{
			get => GetProperty(ref _limitOnYAxis);
			set => SetProperty(ref _limitOnYAxis, value);
		}

		[Ordinal(16)] 
		[RED("limitOnZAxis")] 
		public animFloatClamp LimitOnZAxis
		{
			get => GetProperty(ref _limitOnZAxis);
			set => SetProperty(ref _limitOnZAxis, value);
		}

		public animAnimNode_TranslationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
