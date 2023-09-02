
namespace WolvenKit.RED4.Types
{
	public abstract partial class animIAnimStateTransitionCondition : ISerializable
	{
		public animIAnimStateTransitionCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
