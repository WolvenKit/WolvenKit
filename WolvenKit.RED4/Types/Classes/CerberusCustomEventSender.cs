
namespace WolvenKit.RED4.Types
{
	public partial class CerberusCustomEventSender : AISignalSenderTask
	{
		public CerberusCustomEventSender()
		{
			Tags = new();
			Flags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
