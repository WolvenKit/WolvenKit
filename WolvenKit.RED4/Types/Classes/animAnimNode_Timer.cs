
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Timer : animAnimNode_FloatValue
	{
		public animAnimNode_Timer()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
