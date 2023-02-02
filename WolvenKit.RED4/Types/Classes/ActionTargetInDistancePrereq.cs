using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionTargetInDistancePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("targetRecord")] 
		public CWeakHandle<gamedataAIActionTarget_Record> TargetRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActionTargetInDistancePrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
