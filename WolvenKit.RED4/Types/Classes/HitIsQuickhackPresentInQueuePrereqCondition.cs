using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIsQuickhackPresentInQueuePrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("hackCategory")] 
		public CWeakHandle<gamedataHackCategory_Record> HackCategory
		{
			get => GetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataHackCategory_Record>>(value);
		}

		[Ordinal(4)] 
		[RED("isTheNextQhInQueue")] 
		public CBool IsTheNextQhInQueue
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public HitIsQuickhackPresentInQueuePrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
