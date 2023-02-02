
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionSecuritySystemNotification_Record
	{
		[RED("notificationType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID NotificationType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("threat")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID Threat
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
