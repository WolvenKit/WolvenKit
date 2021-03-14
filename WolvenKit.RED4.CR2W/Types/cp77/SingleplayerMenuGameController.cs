using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _gogButtonWidgetRef;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CInt32 _savesCount;

		[Ordinal(7)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get
			{
				if (_gogButtonWidgetRef == null)
				{
					_gogButtonWidgetRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "gogButtonWidgetRef", cr2w, this);
				}
				return _gogButtonWidgetRef;
			}
			set
			{
				if (_gogButtonWidgetRef == value)
				{
					return;
				}
				_gogButtonWidgetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get
			{
				if (_savesCount == null)
				{
					_savesCount = (CInt32) CR2WTypeManager.Create("Int32", "savesCount", cr2w, this);
				}
				return _savesCount;
			}
			set
			{
				if (_savesCount == value)
				{
					return;
				}
				_savesCount = value;
				PropertySet(this);
			}
		}

		public SingleplayerMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
