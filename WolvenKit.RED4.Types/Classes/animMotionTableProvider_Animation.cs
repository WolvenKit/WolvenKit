
namespace WolvenKit.RED4.Types
{
	public partial class animMotionTableProvider_Animation : animIMotionTableProvider
	{
		public animMotionTableProvider_Animation()
		{
			Id = -1;
			ParentId = -1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
