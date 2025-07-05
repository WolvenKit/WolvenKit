
namespace WolvenKit.RED4.Types
{
	public partial class animMotionTableProvider_StaticSwitch : animIMotionTableProvider
	{
		public animMotionTableProvider_StaticSwitch()
		{
			Id = -1;
			ParentId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
