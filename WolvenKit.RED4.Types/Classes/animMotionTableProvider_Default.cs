
namespace WolvenKit.RED4.Types
{
	public partial class animMotionTableProvider_Default : animIMotionTableProvider
	{
		public animMotionTableProvider_Default()
		{
			Id = -1;
			ParentId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
