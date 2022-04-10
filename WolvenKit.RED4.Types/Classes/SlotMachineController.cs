using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlotMachineController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("barrelAnimationID")] 
		public CName BarrelAnimationID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("winAnimationsID")] 
		public CArray<CName> WinAnimationsID
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("looseAnimationID")] 
		public CName LooseAnimationID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("slotWidgets")] 
		public CArray<inkWidgetReference> SlotWidgets
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(5)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("winChance")] 
		public CInt32 WinChance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("maxWinChance")] 
		public CInt32 MaxWinChance
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("slots")] 
		public CArray<CWeakHandle<SlotMachineSlot>> Slots
		{
			get => GetPropertyValue<CArray<CWeakHandle<SlotMachineSlot>>>();
			set => SetPropertyValue<CArray<CWeakHandle<SlotMachineSlot>>>(value);
		}

		[Ordinal(9)] 
		[RED("barellAnimation")] 
		public CHandle<inkanimProxy> BarellAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(10)] 
		[RED("outcomeAnimation")] 
		public CHandle<inkanimProxy> OutcomeAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(11)] 
		[RED("shouldWinNextTime")] 
		public CBool ShouldWinNextTime
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SlotMachineController()
		{
			WinAnimationsID = new();
			SlotWidgets = new();
			ImagePresets = new();
			MaxWinChance = 100;
			Slots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
