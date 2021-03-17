using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animDyngConstraintEllipsoid_ : animIDyngConstraint
	{
		private animTransformIndex _bone;
		private QsTransform _ellipsoidTransformLS;
		private CFloat _constraintRadius;
		private CFloat _constraintScale1;
		private CFloat _constraintScale2;

		[Ordinal(1)] 
		[RED("bone")] 
		public animTransformIndex Bone
		{
			get => GetProperty(ref _bone);
			set => SetProperty(ref _bone, value);
		}

		[Ordinal(2)] 
		[RED("ellipsoidTransformLS")] 
		public QsTransform EllipsoidTransformLS
		{
			get => GetProperty(ref _ellipsoidTransformLS);
			set => SetProperty(ref _ellipsoidTransformLS, value);
		}

		[Ordinal(3)] 
		[RED("constraintRadius")] 
		public CFloat ConstraintRadius
		{
			get => GetProperty(ref _constraintRadius);
			set => SetProperty(ref _constraintRadius, value);
		}

		[Ordinal(4)] 
		[RED("constraintScale1")] 
		public CFloat ConstraintScale1
		{
			get => GetProperty(ref _constraintScale1);
			set => SetProperty(ref _constraintScale1, value);
		}

		[Ordinal(5)] 
		[RED("constraintScale2")] 
		public CFloat ConstraintScale2
		{
			get => GetProperty(ref _constraintScale2);
			set => SetProperty(ref _constraintScale2, value);
		}

		public animDyngConstraintEllipsoid_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
