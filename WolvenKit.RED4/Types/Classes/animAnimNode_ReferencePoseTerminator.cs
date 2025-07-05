
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ReferencePoseTerminator : animAnimNode_Base
	{
		public animAnimNode_ReferencePoseTerminator()
		{
			Id = uint.MaxValue;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
