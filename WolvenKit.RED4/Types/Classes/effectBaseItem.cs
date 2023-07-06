
namespace WolvenKit.RED4.Types
{
	public abstract partial class effectBaseItem : ISerializable
	{
		public effectBaseItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
