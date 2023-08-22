
namespace WolvenKit.RED4.Types
{
	public abstract partial class ActionEnum : ActionInt
	{
		public ActionEnum()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
