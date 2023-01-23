using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseInfoLoggerEntry_Transform : animPoseInfoLoggerEntry
	{
		[Ordinal(0)] 
		[RED("transform")] 
		public animTransformIndex Transform
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		[Ordinal(1)] 
		[RED("logInModelSpace")] 
		public CBool LogInModelSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animPoseInfoLoggerEntry_Transform()
		{
			Transform = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
