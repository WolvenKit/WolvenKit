
namespace WolvenKit.RED4.Types
{
	public abstract partial class entAttachEffectEvent : redEvent
	{
		public entAttachEffectEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
