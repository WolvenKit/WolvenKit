
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetWorldPosition_Record
	{
		[RED("checkForNavmesh")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckForNavmesh
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("customPositionTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID CustomPositionTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("maxOffsetFromTarget")]
		[REDProperty(IsIgnored = true)]
		public Vector3 MaxOffsetFromTarget
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("minOffsetFromTarget")]
		[REDProperty(IsIgnored = true)]
		public Vector3 MinOffsetFromTarget
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("randomizePoint")]
		[REDProperty(IsIgnored = true)]
		public CBool RandomizePoint
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("referenceTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ReferenceTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("useLocalSpace")]
		[REDProperty(IsIgnored = true)]
		public CBool UseLocalSpace
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
