using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotButtonTap : redEvent
	{
		private CEnum<EDPadSlot> _dPadItemDirection;

		[Ordinal(0)] 
		[RED("dPadItemDirection")] 
		public CEnum<EDPadSlot> DPadItemDirection
		{
			get => GetProperty(ref _dPadItemDirection);
			set => SetProperty(ref _dPadItemDirection, value);
		}

		public QuickSlotButtonTap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
