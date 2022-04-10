
namespace WolvenKit.RED4.Types
{
	public partial class redTOMLBaseValue : ISerializable
	{
		public redTOMLBaseValue()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
