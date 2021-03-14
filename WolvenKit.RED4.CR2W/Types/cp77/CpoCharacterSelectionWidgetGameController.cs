using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterSelectionWidgetGameController : gameuiWidgetGameController
	{
		private CString _defaultCharacterTexturePart;
		private CString _soloCharacterTexturePart;
		private CArray<wCHandle<inkHorizontalPanelWidget>> _horizontalPanelsList;
		private CInt32 _amount;

		[Ordinal(2)] 
		[RED("defaultCharacterTexturePart")] 
		public CString DefaultCharacterTexturePart
		{
			get
			{
				if (_defaultCharacterTexturePart == null)
				{
					_defaultCharacterTexturePart = (CString) CR2WTypeManager.Create("String", "defaultCharacterTexturePart", cr2w, this);
				}
				return _defaultCharacterTexturePart;
			}
			set
			{
				if (_defaultCharacterTexturePart == value)
				{
					return;
				}
				_defaultCharacterTexturePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("soloCharacterTexturePart")] 
		public CString SoloCharacterTexturePart
		{
			get
			{
				if (_soloCharacterTexturePart == null)
				{
					_soloCharacterTexturePart = (CString) CR2WTypeManager.Create("String", "soloCharacterTexturePart", cr2w, this);
				}
				return _soloCharacterTexturePart;
			}
			set
			{
				if (_soloCharacterTexturePart == value)
				{
					return;
				}
				_soloCharacterTexturePart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("horizontalPanelsList")] 
		public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get
			{
				if (_horizontalPanelsList == null)
				{
					_horizontalPanelsList = (CArray<wCHandle<inkHorizontalPanelWidget>>) CR2WTypeManager.Create("array:whandle:inkHorizontalPanelWidget", "horizontalPanelsList", cr2w, this);
				}
				return _horizontalPanelsList;
			}
			set
			{
				if (_horizontalPanelsList == value)
				{
					return;
				}
				_horizontalPanelsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public CpoCharacterSelectionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
