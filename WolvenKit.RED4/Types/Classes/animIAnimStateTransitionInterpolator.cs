
namespace WolvenKit.RED4.Types
{
	public abstract partial class animIAnimStateTransitionInterpolator : ISerializable
	{
		public animIAnimStateTransitionInterpolator()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
