
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_StageFloatEntry : animAnimNode_FloatValue
	{
		public animAnimNode_StageFloatEntry()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
