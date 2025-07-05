
namespace WolvenKit.RED4.Types
{
	public partial class CustomEventSender : AISignalSenderTask
	{
		public CustomEventSender()
		{
			Tags = new();
			Flags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
