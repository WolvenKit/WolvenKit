
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBaseDrivingParameters_Record
	{
		[RED("accel")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Accel
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("boostStats")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BoostStats
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("brake")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Brake
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("panic")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Panic
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("steering")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Steering
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("steeringReverse")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID SteeringReverse
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("stopping")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Stopping
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("traction")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Traction
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("vision")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Vision
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
