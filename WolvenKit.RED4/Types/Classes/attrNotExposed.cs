
namespace WolvenKit.RED4.Types
{
	public partial class attrNotExposed : attrAttribute
	{
		public attrNotExposed()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
