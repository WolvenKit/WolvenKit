
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIStatPoolCond_Record
	{
		[RED("isIncreasing")]
		[REDProperty(IsIgnored = true)]
		public CInt32 IsIncreasing
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("percentage")]
		[REDProperty(IsIgnored = true)]
		public Vector2 Percentage
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}
		
		[RED("statPool")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID StatPool
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
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
