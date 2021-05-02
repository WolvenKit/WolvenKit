using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickSlotKeyboardTap : redEvent
	{
		private CInt32 _keyIndex;

		[Ordinal(0)] 
		[RED("keyIndex")] 
		public CInt32 KeyIndex
		{
			get => GetProperty(ref _keyIndex);
			set => SetProperty(ref _keyIndex, value);
		}

		public QuickSlotKeyboardTap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
