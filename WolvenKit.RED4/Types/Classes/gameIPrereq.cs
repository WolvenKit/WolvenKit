
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPrereq : IScriptable
	{
		public gameIPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
