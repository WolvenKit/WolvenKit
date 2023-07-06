
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITimeState : ISerializable
	{
		public gameITimeState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
