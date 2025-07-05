
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIValidCoversCond_Record
	{
		[RED("checkCurrentlyActiveRing")]
		[REDProperty(IsIgnored = true)]
		public CBool CheckCurrentlyActiveRing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("coversWithLOS")]
		[REDProperty(IsIgnored = true)]
		public CInt32 CoversWithLOS
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("limitToRings")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> LimitToRings
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
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
