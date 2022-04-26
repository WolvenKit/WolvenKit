
namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ForegroundSegmentBegin : animAnimNode_OnePoseInput
	{
		public animAnimNode_ForegroundSegmentBegin()
		{
			Id = 4294967295;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
