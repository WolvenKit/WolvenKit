using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerQuickhackData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("actionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> ActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PlayerQuickhackData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
