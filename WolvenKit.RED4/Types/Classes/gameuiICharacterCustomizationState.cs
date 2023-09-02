
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiICharacterCustomizationState : IScriptable
	{
		public gameuiICharacterCustomizationState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
