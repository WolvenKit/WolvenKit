
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameEffectDurationModifier : IScriptable
	{
		public gameEffectDurationModifier()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
