
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_GraphSlotInput : animAnimNode_Base
	{
		public animAnimNode_GraphSlotInput()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
