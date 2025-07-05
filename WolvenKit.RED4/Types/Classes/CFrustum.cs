
namespace WolvenKit.RED4.Types
{
	[REDClass(SerializeDefault = true)]
	public partial class CFrustum : RedBaseClass
	{
		public CFrustum()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
