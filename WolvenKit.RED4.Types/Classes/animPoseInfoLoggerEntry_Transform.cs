using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
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
	}
}
