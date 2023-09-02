
namespace WolvenKit.RED4.Types
{
	public abstract partial class UIGenderHelper : IScriptable
	{
		public UIGenderHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
