
namespace WolvenKit.RED4.Types
{
	public partial class redEvent : IScriptable
	{
		public redEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
