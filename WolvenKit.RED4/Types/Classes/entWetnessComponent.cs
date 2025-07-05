
namespace WolvenKit.RED4.Types
{
	public partial class entWetnessComponent : entIComponent
	{
		public entWetnessComponent()
		{
			Name = "wetness";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
