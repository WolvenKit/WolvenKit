
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameDelaySystemScriptableSysRequestStruct : gameDelaySystemDelayStruct
	{
		public gameDelaySystemScriptableSysRequestStruct()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
