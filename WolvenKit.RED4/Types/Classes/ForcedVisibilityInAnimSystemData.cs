using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForcedVisibilityInAnimSystemData : IScriptable
	{
		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(2)] 
		[RED("forcedVisibleOnlyInFrustum")] 
		public CBool ForcedVisibleOnlyInFrustum
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ForcedVisibilityInAnimSystemData()
		{
			DelayID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
