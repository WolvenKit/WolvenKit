
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionShootToPoint_Record
	{
		[RED("pointPosition")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector3> PointPosition
		{
			get => GetPropertyValue<CArray<Vector3>>();
			set => SetPropertyValue<CArray<Vector3>>(value);
		}
		
		[RED("positionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID PositionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rotationObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RotationObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("targetPositionObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID TargetPositionObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("waypointTag")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> WaypointTag
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
