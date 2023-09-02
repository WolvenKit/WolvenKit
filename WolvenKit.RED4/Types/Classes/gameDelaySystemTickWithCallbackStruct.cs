
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemTickWithCallbackStruct : gameDelaySystemTickStruct
	{
		public gameDelaySystemTickWithCallbackStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
