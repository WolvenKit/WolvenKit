
namespace WolvenKit.RED4.Types
{
	public abstract partial class questPuppetsEffector : ISerializable
	{
		public questPuppetsEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
