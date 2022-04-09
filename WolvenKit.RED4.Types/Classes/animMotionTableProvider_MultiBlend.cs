
namespace WolvenKit.RED4.Types
{
	public partial class animMotionTableProvider_MultiBlend : animIMotionTableProvider
	{
		public animMotionTableProvider_MultiBlend()
		{
			Id = -1;
			ParentId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
