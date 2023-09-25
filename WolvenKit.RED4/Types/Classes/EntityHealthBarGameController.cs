using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EntityHealthBarGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("healthControllerRef")] 
		public inkWidgetReference HealthControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("healthPercentageRef")] 
		public inkTextWidgetReference HealthPercentageRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("targetEntityRef")] 
		public gameEntityReference TargetEntityRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(5)] 
		[RED("healthStatListener")] 
		public CHandle<EntityHealthStatListener> HealthStatListener
		{
			get => GetPropertyValue<CHandle<EntityHealthStatListener>>();
			set => SetPropertyValue<CHandle<EntityHealthStatListener>>(value);
		}

		[Ordinal(6)] 
		[RED("healthController")] 
		public CWeakHandle<NameplateBarLogicController> HealthController
		{
			get => GetPropertyValue<CWeakHandle<NameplateBarLogicController>>();
			set => SetPropertyValue<CWeakHandle<NameplateBarLogicController>>(value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(8)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public EntityHealthBarGameController()
		{
			HealthControllerRef = new inkWidgetReference();
			HealthPercentageRef = new inkTextWidgetReference();
			TargetEntityRef = new gameEntityReference { Names = new() };
			GameInstance = new ScriptGameInstance();
			TargetEntityID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
