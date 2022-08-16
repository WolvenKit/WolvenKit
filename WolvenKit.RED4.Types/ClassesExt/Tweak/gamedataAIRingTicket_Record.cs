
namespace WolvenKit.RED4.Types
{
	public partial class gamedataAIRingTicket_Record
	{
		[RED("ringType")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID RingType
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
