using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
	{
		private animTransformIndex _transform;
		private CBool _logInModelSpace;

		[Ordinal(0)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(1)] 
		[RED("logInModelSpace")] 
		public CBool LogInModelSpace
		{
			get => GetProperty(ref _logInModelSpace);
			set => SetProperty(ref _logInModelSpace, value);
		}

		public animPoseInfoLoggerEntry_Transform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
