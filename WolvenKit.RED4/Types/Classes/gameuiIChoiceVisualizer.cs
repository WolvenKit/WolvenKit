
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiIChoiceVisualizer : ISerializable
	{
		public gameuiIChoiceVisualizer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
