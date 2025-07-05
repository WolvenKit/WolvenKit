
namespace WolvenKit.RED4.Types
{
	public partial class IEvaluator : ISerializable
	{
		public IEvaluator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
