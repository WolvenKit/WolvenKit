
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIConditionType : ISerializable
	{
		public questIConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
