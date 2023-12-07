using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ICECounterHackEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("quickhackObjectActionID")] 
		public TweakDBID QuickhackObjectActionID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("quickhackObjectActionRecord")] 
		public CWeakHandle<gamedataObjectAction_Record> QuickhackObjectActionRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataObjectAction_Record>>(value);
		}

		public ICECounterHackEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
