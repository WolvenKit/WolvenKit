
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICalculatePathCond_Record
	{
		[RED("allowedOffMeshTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AllowedOffMeshTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("checkDynamicObstacle")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckDynamicObstacle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("checkStraightPath")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckStraightPath
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("directionAngle")]
		[REDProperty(IsIgnored = true)]
		public CFloat DirectionAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("distance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("startPositionOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 StartPositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("tolerance")]
		[REDProperty(IsIgnored = true)]
		public CFloat Tolerance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
