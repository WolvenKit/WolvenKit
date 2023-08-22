
namespace WolvenKit.RED4.Types
{
	public abstract partial class EffectDataHelper : IScriptable
	{
		public EffectDataHelper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
