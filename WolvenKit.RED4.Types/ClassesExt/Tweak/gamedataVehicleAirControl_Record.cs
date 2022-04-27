
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleAirControl_Record
	{
		[RED("anglePID")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> AnglePID
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("flippedOverRecoveryPID")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> FlippedOverRecoveryPID
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("massReference")]
		[REDProperty(IsIgnored = true)]
		public CFloat MassReference
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("pitch")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Pitch
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("roll")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Roll
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("velocityPID")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> VelocityPID
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("yaw")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Yaw
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
