using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActionTargetPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("targetRecord")] 
		public CWeakHandle<gamedataAIActionTarget_Record> TargetRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataAIActionTarget_Record>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ActionTargetPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
