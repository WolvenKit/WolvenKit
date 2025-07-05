
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnIGameplayActionData : ISerializable
	{
		public scnIGameplayActionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
