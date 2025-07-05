using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerksWireConnection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetSlot")] 
		public CEnum<gamedataNewPerkSlotType> TargetSlot
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkSlotType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkSlotType>>(value);
		}

		[Ordinal(1)] 
		[RED("dependanciesPresenceToggle")] 
		public CBool DependanciesPresenceToggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("connectionDependancies")] 
		public CArray<CEnum<gamedataNewPerkSlotType>> ConnectionDependancies
		{
			get => GetPropertyValue<CArray<CEnum<gamedataNewPerkSlotType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataNewPerkSlotType>>>(value);
		}

		[Ordinal(3)] 
		[RED("wires")] 
		public CArray<inkWidgetReference> Wires
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		public NewPerksWireConnection()
		{
			ConnectionDependancies = new();
			Wires = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
