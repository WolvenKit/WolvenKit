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
			get
			{
				if (_keyIndex == null)
				{
					_keyIndex = (CInt32) CR2WTypeManager.Create("Int32", "keyIndex", cr2w, this);
				}
				return _keyIndex;
			}
			set
			{
				if (_keyIndex == value)
				{
					return;
				}
				_keyIndex = value;
				PropertySet(this);
			}
		}

		public QuickSlotKeyboardTap(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
