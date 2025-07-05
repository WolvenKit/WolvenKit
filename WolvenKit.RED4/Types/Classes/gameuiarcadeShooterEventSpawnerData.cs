using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeShooterEventSpawnerData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("dataName")] 
		public CName DataName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("targetSpawner")] 
		public inkWidgetReference TargetSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("tiedSpawner")] 
		public inkWidgetReference TiedSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("triggerCondition")] 
		public CEnum<gameuiarcadeShooterTriggerType> TriggerCondition
		{
			get => GetPropertyValue<CEnum<gameuiarcadeShooterTriggerType>>();
			set => SetPropertyValue<CEnum<gameuiarcadeShooterTriggerType>>(value);
		}

		[Ordinal(4)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiarcadeShooterEventSpawnerData()
		{
			TargetSpawner = new inkWidgetReference();
			TiedSpawner = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
