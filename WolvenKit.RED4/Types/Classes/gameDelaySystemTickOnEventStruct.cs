
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemTickOnEventStruct : gameDelaySystemTickStruct
	{
		public gameDelaySystemTickOnEventStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
