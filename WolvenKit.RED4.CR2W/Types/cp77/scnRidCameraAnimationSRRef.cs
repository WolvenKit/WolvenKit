using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidCameraAnimationSRRef : CVariable
	{
		private scnRidResourceId _resourceId;
		private scnRidSerialNumber _animationSN;

		[Ordinal(0)] 
		[RED("resourceId")] 
		public scnRidResourceId ResourceId
		{
			get => GetProperty(ref _resourceId);
			set => SetProperty(ref _resourceId, value);
		}

		[Ordinal(1)] 
		[RED("animationSN")] 
		public scnRidSerialNumber AnimationSN
		{
			get => GetProperty(ref _animationSN);
			set => SetProperty(ref _animationSN, value);
		}

		public scnRidCameraAnimationSRRef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
