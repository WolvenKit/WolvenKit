using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlotMachineController : inkWidgetLogicController
	{
		private CName _barrelAnimationID;
		private CArray<CName> _winAnimationsID;
		private CName _looseAnimationID;
		private CArray<inkWidgetReference> _slotWidgets;
		private CArray<CName> _imagePresets;
		private CInt32 _winChance;
		private CInt32 _maxWinChance;
		private CArray<wCHandle<SlotMachineSlot>> _slots;
		private CHandle<inkanimProxy> _barellAnimation;
		private CHandle<inkanimProxy> _outcomeAnimation;
		private CBool _shouldWinNextTime;

		[Ordinal(1)] 
		[RED("barrelAnimationID")] 
		public CName BarrelAnimationID
		{
			get => GetProperty(ref _barrelAnimationID);
			set => SetProperty(ref _barrelAnimationID, value);
		}

		[Ordinal(2)] 
		[RED("winAnimationsID")] 
		public CArray<CName> WinAnimationsID
		{
			get => GetProperty(ref _winAnimationsID);
			set => SetProperty(ref _winAnimationsID, value);
		}

		[Ordinal(3)] 
		[RED("looseAnimationID")] 
		public CName LooseAnimationID
		{
			get => GetProperty(ref _looseAnimationID);
			set => SetProperty(ref _looseAnimationID, value);
		}

		[Ordinal(4)] 
		[RED("slotWidgets")] 
		public CArray<inkWidgetReference> SlotWidgets
		{
			get => GetProperty(ref _slotWidgets);
			set => SetProperty(ref _slotWidgets, value);
		}

		[Ordinal(5)] 
		[RED("imagePresets")] 
		public CArray<CName> ImagePresets
		{
			get => GetProperty(ref _imagePresets);
			set => SetProperty(ref _imagePresets, value);
		}

		[Ordinal(6)] 
		[RED("winChance")] 
		public CInt32 WinChance
		{
			get => GetProperty(ref _winChance);
			set => SetProperty(ref _winChance, value);
		}

		[Ordinal(7)] 
		[RED("maxWinChance")] 
		public CInt32 MaxWinChance
		{
			get => GetProperty(ref _maxWinChance);
			set => SetProperty(ref _maxWinChance, value);
		}

		[Ordinal(8)] 
		[RED("slots")] 
		public CArray<wCHandle<SlotMachineSlot>> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(9)] 
		[RED("barellAnimation")] 
		public CHandle<inkanimProxy> BarellAnimation
		{
			get => GetProperty(ref _barellAnimation);
			set => SetProperty(ref _barellAnimation, value);
		}

		[Ordinal(10)] 
		[RED("outcomeAnimation")] 
		public CHandle<inkanimProxy> OutcomeAnimation
		{
			get => GetProperty(ref _outcomeAnimation);
			set => SetProperty(ref _outcomeAnimation, value);
		}

		[Ordinal(11)] 
		[RED("shouldWinNextTime")] 
		public CBool ShouldWinNextTime
		{
			get => GetProperty(ref _shouldWinNextTime);
			set => SetProperty(ref _shouldWinNextTime, value);
		}

		public SlotMachineController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
