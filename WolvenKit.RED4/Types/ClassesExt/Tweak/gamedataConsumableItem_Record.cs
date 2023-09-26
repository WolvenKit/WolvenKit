
namespace WolvenKit.RED4.Types
{
	public partial class gamedataConsumableItem_Record
	{
		[RED("atlasIcon")]
		[REDProperty(IsIgnored = true)]
		public CName AtlasIcon
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("castPoint")]
		[REDProperty(IsIgnored = true)]
		public CFloat CastPoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("consumableBaseName")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ConsumableBaseName
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("consumableType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID ConsumableType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("cycleDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat CycleDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("initBlendDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat InitBlendDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("removePoint")]
		[REDProperty(IsIgnored = true)]
		public CFloat RemovePoint
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
