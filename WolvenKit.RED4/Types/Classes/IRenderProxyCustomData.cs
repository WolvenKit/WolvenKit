
namespace WolvenKit.RED4.Types
{
	public abstract partial class IRenderProxyCustomData : RedBaseClass
	{
		public IRenderProxyCustomData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
