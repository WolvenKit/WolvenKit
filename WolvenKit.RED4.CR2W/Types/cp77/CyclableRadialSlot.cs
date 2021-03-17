using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyclableRadialSlot : WeaponRadialSlot
	{
		private inkWidgetReference _leftArrowEmpty;
		private inkWidgetReference _leftArrowFull;
		private inkWidgetReference _rightArrowEmpty;
		private inkWidgetReference _rightArrowFull;
		private CBool _canCycle;
		private CBool _isCycling;
		private CBool _wasCyclingRight;
		private CEnum<gameEHotkey> _hotkey;

		[Ordinal(11)] 
		[RED("leftArrowEmpty")] 
		public inkWidgetReference LeftArrowEmpty
		{
			get => GetProperty(ref _leftArrowEmpty);
			set => SetProperty(ref _leftArrowEmpty, value);
		}

		[Ordinal(12)] 
		[RED("leftArrowFull")] 
		public inkWidgetReference LeftArrowFull
		{
			get => GetProperty(ref _leftArrowFull);
			set => SetProperty(ref _leftArrowFull, value);
		}

		[Ordinal(13)] 
		[RED("rightArrowEmpty")] 
		public inkWidgetReference RightArrowEmpty
		{
			get => GetProperty(ref _rightArrowEmpty);
			set => SetProperty(ref _rightArrowEmpty, value);
		}

		[Ordinal(14)] 
		[RED("rightArrowFull")] 
		public inkWidgetReference RightArrowFull
		{
			get => GetProperty(ref _rightArrowFull);
			set => SetProperty(ref _rightArrowFull, value);
		}

		[Ordinal(15)] 
		[RED("canCycle")] 
		public CBool CanCycle
		{
			get => GetProperty(ref _canCycle);
			set => SetProperty(ref _canCycle, value);
		}

		[Ordinal(16)] 
		[RED("isCycling")] 
		public CBool IsCycling
		{
			get => GetProperty(ref _isCycling);
			set => SetProperty(ref _isCycling, value);
		}

		[Ordinal(17)] 
		[RED("wasCyclingRight")] 
		public CBool WasCyclingRight
		{
			get => GetProperty(ref _wasCyclingRight);
			set => SetProperty(ref _wasCyclingRight, value);
		}

		[Ordinal(18)] 
		[RED("hotkey")] 
		public CEnum<gameEHotkey> Hotkey
		{
			get => GetProperty(ref _hotkey);
			set => SetProperty(ref _hotkey, value);
		}

		public CyclableRadialSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
