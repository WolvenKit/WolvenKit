
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionForceHitReaction_Record
	{
		[RED("animVariation")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AnimVariation
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
		
		[RED("hitBodyPart")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitBodyPart
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitDirection")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitDirection
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitIntensity")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitIntensity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitSource")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitSource
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("hitType")]
		[REDProperty(IsIgnored = true)]
		public CInt32 HitType
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("stance")]
		[REDProperty(IsIgnored = true)]
		public CInt32 Stance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
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
