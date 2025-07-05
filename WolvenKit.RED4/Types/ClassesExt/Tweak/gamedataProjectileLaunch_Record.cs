
namespace WolvenKit.RED4.Types
{
	public partial class gamedataProjectileLaunch_Record
	{
		[RED("applyAdditiveProjectileSpiraling")]
		[REDProperty(IsIgnored = true)]
		public CBool ApplyAdditiveProjectileSpiraling
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("canTrackDevices")]
		[REDProperty(IsIgnored = true)]
		public CBool CanTrackDevices
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("type")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Type
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
