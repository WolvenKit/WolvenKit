using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCooldownGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("maxCooldowns")] 
		public CInt32 MaxCooldowns
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("cooldownTitle")] 
		public inkWidgetReference CooldownTitle
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("cooldownContainer")] 
		public inkCompoundWidgetReference CooldownContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("poolHolder")] 
		public inkCompoundWidgetReference PoolHolder
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("mode")] 
		public CEnum<ECooldownGameControllerMode> Mode
		{
			get => GetPropertyValue<CEnum<ECooldownGameControllerMode>>();
			set => SetPropertyValue<CEnum<ECooldownGameControllerMode>>(value);
		}

		[Ordinal(7)] 
		[RED("effectTypes")] 
		public CArray<CEnum<gamedataStatusEffectType>> EffectTypes
		{
			get => GetPropertyValue<CArray<CEnum<gamedataStatusEffectType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataStatusEffectType>>>(value);
		}

		[Ordinal(8)] 
		[RED("cooldownPool")] 
		public CArray<CWeakHandle<SingleCooldownManager>> CooldownPool
		{
			get => GetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>(value);
		}

		[Ordinal(9)] 
		[RED("matchBuffer")] 
		public CArray<CWeakHandle<SingleCooldownManager>> MatchBuffer
		{
			get => GetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SingleCooldownManager>>>(value);
		}

		[Ordinal(10)] 
		[RED("buffsCallback")] 
		public CHandle<redCallbackObject> BuffsCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(11)] 
		[RED("debuffsCallback")] 
		public CHandle<redCallbackObject> DebuffsCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(12)] 
		[RED("blackboardDef")] 
		public CHandle<UI_PlayerBioMonitorDef> BlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>();
			set => SetPropertyValue<CHandle<UI_PlayerBioMonitorDef>>(value);
		}

		[Ordinal(13)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public gameuiCooldownGameController()
		{
			CooldownTitle = new inkWidgetReference();
			CooldownContainer = new inkCompoundWidgetReference();
			PoolHolder = new inkCompoundWidgetReference();
			EffectTypes = new();
			CooldownPool = new();
			MatchBuffer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
