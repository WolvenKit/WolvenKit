
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSetTargetByTag_Record
	{
		[RED("allowedOffMeshTags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> AllowedOffMeshTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("avoidSelectingSameTarget")]
		[REDProperty(IsIgnored = true)]
		public CBool AvoidSelectingSameTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("avoidSelectingSameTargetMethod")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AvoidSelectingSameTargetMethod
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lineOfSightTarget")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID LineOfSightTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("rangeFromObj")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RangeFromObj
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("rangeFromOwner")]
		[REDProperty(IsIgnored = true)]
		public Vector2 RangeFromOwner
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("rangeObj")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RangeObj
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("selectionMethod")]
		[REDProperty(IsIgnored = true)]
		public CName SelectionMethod
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("tag")]
		[REDProperty(IsIgnored = true)]
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
