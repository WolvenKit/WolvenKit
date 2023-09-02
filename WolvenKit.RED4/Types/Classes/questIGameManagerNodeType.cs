
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIGameManagerNodeType : questISignalStoppingNodeType
	{
		public questIGameManagerNodeType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
