
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameJournalBaseResource : CResource
	{
		public gameJournalBaseResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
