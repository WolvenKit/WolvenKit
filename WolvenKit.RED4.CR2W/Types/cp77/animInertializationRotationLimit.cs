using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animInertializationRotationLimit : CVariable
	{
		private animTransformIndex _constrainedTransform;
		private animInertializationFloatClamp _limitOnX;
		private animInertializationFloatClamp _limitOnY;
		private animInertializationFloatClamp _limitOnZ;

		[Ordinal(0)] 
		[RED("constrainedTransform")] 
		public animTransformIndex ConstrainedTransform
		{
			get => GetProperty(ref _constrainedTransform);
			set => SetProperty(ref _constrainedTransform, value);
		}

		[Ordinal(1)] 
		[RED("limitOnX")] 
		public animInertializationFloatClamp LimitOnX
		{
			get => GetProperty(ref _limitOnX);
			set => SetProperty(ref _limitOnX, value);
		}

		[Ordinal(2)] 
		[RED("limitOnY")] 
		public animInertializationFloatClamp LimitOnY
		{
			get => GetProperty(ref _limitOnY);
			set => SetProperty(ref _limitOnY, value);
		}

		[Ordinal(3)] 
		[RED("limitOnZ")] 
		public animInertializationFloatClamp LimitOnZ
		{
			get => GetProperty(ref _limitOnZ);
			set => SetProperty(ref _limitOnZ, value);
		}

		public animInertializationRotationLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
