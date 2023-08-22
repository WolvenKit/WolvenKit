
namespace WolvenKit.RED4.Types
{
	public abstract partial class gsmPopupState : gsmState
	{
		public gsmPopupState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
