
namespace WolvenKit.RED4.Types
{
	public abstract partial class BluelineConditionTypeBase : ScriptConditionTypeBase
	{
		public BluelineConditionTypeBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
