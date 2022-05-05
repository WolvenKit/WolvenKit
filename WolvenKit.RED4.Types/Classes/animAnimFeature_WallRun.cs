using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_WallRun : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("wallOnRightSide")] 
		public CBool WallOnRightSide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("wallPosition")] 
		public Vector4 WallPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("wallNormal")] 
		public Vector4 WallNormal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_WallRun()
		{
			WallPosition = new();
			WallNormal = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
