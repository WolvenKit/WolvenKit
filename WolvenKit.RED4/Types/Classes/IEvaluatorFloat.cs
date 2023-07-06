
namespace WolvenKit.RED4.Types
{
	public abstract partial class IEvaluatorFloat : IEvaluator
	{
		public IEvaluatorFloat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
