
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAILoSPositionCond_Record
	{
		[RED("maxNotFoundTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxNotFoundTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxRadiusXY")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRadiusXY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxRadiusZ")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxRadiusZ
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("target")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Target
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Type
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
