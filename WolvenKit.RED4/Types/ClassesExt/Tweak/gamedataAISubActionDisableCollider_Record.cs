
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAISubActionDisableCollider_Record
	{
		[RED("delay")]
		[REDProperty(IsIgnored = true)]
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("disable")]
		[REDProperty(IsIgnored = true)]
		public CBool Disable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("enableOnDeactivate")]
		[REDProperty(IsIgnored = true)]
		public CBool EnableOnDeactivate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
