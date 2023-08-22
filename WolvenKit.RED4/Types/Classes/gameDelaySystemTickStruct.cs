
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemTickStruct : ISerializable
	{
		public gameDelaySystemTickStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
