
namespace WolvenKit.RED4.Types
{
	public abstract partial class ATooltipData : IScriptable
	{
		public ATooltipData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
