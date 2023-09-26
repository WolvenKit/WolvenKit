
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAICalculateLineOfSightVector_Record
	{
		[RED("endPosition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID EndPosition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("endPositionOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 EndPositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("ignoreNonPenetrableObj")]
		[REDProperty(IsIgnored = true)]
		public CBool IgnoreNonPenetrableObj
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("startPosition")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StartPosition
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("startPositionOffset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 StartPositionOffset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
	}
}
