
namespace WolvenKit.RED4.Types
{
	public partial class gamedataNetworkPingingParameteres_Record
	{
		[RED("allowSimultanousPinging")]
		[REDProperty(IsIgnored = true)]
		public CBool AllowSimultanousPinging
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("ammountOfIntervals")]
		[REDProperty(IsIgnored = true)]
		public CInt32 AmmountOfIntervals
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("directPingDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat DirectPingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("forceInstantBeamKill")]
		[REDProperty(IsIgnored = true)]
		public CBool ForceInstantBeamKill
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("maxFreePingLinks")]
		[REDProperty(IsIgnored = true)]
		public CInt32 MaxFreePingLinks
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
		
		[RED("networkRevealDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat NetworkRevealDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pingRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat PingRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pulseRange")]
		[REDProperty(IsIgnored = true)]
		public CFloat PulseRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pulseRealObjects")]
		[REDProperty(IsIgnored = true)]
		public CBool PulseRealObjects
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("quickHacksExposedByDefaul")]
		[REDProperty(IsIgnored = true)]
		public CBool QuickHacksExposedByDefaul
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("reavealNetworkOnMaster")]
		[REDProperty(IsIgnored = true)]
		public CBool ReavealNetworkOnMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("revealLinksAfterLeavingFocusDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat RevealLinksAfterLeavingFocusDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("revealMaster")]
		[REDProperty(IsIgnored = true)]
		public CBool RevealMaster
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("revealMasterAfterLeavingFocusDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat RevealMasterAfterLeavingFocusDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("revealSlave")]
		[REDProperty(IsIgnored = true)]
		public CBool RevealSlave
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldNetworkElementsPersistAfterFocus")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldNetworkElementsPersistAfterFocus
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("shouldRevealNetworkAfterPulse")]
		[REDProperty(IsIgnored = true)]
		public CBool ShouldRevealNetworkAfterPulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("showOnlyTargetQuickHacks")]
		[REDProperty(IsIgnored = true)]
		public CBool ShowOnlyTargetQuickHacks
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("spacePingAppearModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpacePingAppearModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("spacePingDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat SpacePingDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("suppressPingIfBackdoorsFound")]
		[REDProperty(IsIgnored = true)]
		public CBool SuppressPingIfBackdoorsFound
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("usePulse")]
		[REDProperty(IsIgnored = true)]
		public CBool UsePulse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("virtualNetwork")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID VirtualNetwork
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
