
namespace WolvenKit.RED4.Types
{
	public partial class gamedataHomingGDM_Record
	{
		[RED("flyToTargetParameters")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FlyToTargetParameters
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("flyUpParameters")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID FlyUpParameters
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("freezeDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("freezeDelayAfterBounce")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDelayAfterBounce
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("freezeDuration")]
		[REDProperty(IsIgnored = true)]
		public CFloat FreezeDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnAltitude")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnAltitude
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lockOnFailDetonationDelay")]
		[REDProperty(IsIgnored = true)]
		public CFloat LockOnFailDetonationDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
