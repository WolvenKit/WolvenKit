using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LcdScreenILogicController : inkWidgetLogicController
	{
		private inkWidgetReference _defaultUI;
		private inkVideoWidgetReference _mainDisplayWidget;
		private inkTextWidgetReference _messegeWidget;
		private inkImageWidgetReference _backgroundWidget;
		private wCHandle<gamedataScreenMessageData_Record> _messegeRecord;
		private CBool _replaceTextWithCustomNumber;
		private CInt32 _customNumber;

		[Ordinal(1)] 
		[RED("defaultUI")] 
		public inkWidgetReference DefaultUI
		{
			get
			{
				if (_defaultUI == null)
				{
					_defaultUI = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "defaultUI", cr2w, this);
				}
				return _defaultUI;
			}
			set
			{
				if (_defaultUI == value)
				{
					return;
				}
				_defaultUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("mainDisplayWidget")] 
		public inkVideoWidgetReference MainDisplayWidget
		{
			get
			{
				if (_mainDisplayWidget == null)
				{
					_mainDisplayWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "mainDisplayWidget", cr2w, this);
				}
				return _mainDisplayWidget;
			}
			set
			{
				if (_mainDisplayWidget == value)
				{
					return;
				}
				_mainDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get
			{
				if (_messegeWidget == null)
				{
					_messegeWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "messegeWidget", cr2w, this);
				}
				return _messegeWidget;
			}
			set
			{
				if (_messegeWidget == value)
				{
					return;
				}
				_messegeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("backgroundWidget")] 
		public inkImageWidgetReference BackgroundWidget
		{
			get
			{
				if (_backgroundWidget == null)
				{
					_backgroundWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "backgroundWidget", cr2w, this);
				}
				return _backgroundWidget;
			}
			set
			{
				if (_backgroundWidget == value)
				{
					return;
				}
				_backgroundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("messegeRecord")] 
		public wCHandle<gamedataScreenMessageData_Record> MessegeRecord
		{
			get
			{
				if (_messegeRecord == null)
				{
					_messegeRecord = (wCHandle<gamedataScreenMessageData_Record>) CR2WTypeManager.Create("whandle:gamedataScreenMessageData_Record", "messegeRecord", cr2w, this);
				}
				return _messegeRecord;
			}
			set
			{
				if (_messegeRecord == value)
				{
					return;
				}
				_messegeRecord = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("replaceTextWithCustomNumber")] 
		public CBool ReplaceTextWithCustomNumber
		{
			get
			{
				if (_replaceTextWithCustomNumber == null)
				{
					_replaceTextWithCustomNumber = (CBool) CR2WTypeManager.Create("Bool", "replaceTextWithCustomNumber", cr2w, this);
				}
				return _replaceTextWithCustomNumber;
			}
			set
			{
				if (_replaceTextWithCustomNumber == value)
				{
					return;
				}
				_replaceTextWithCustomNumber = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("customNumber")] 
		public CInt32 CustomNumber
		{
			get
			{
				if (_customNumber == null)
				{
					_customNumber = (CInt32) CR2WTypeManager.Create("Int32", "customNumber", cr2w, this);
				}
				return _customNumber;
			}
			set
			{
				if (_customNumber == value)
				{
					return;
				}
				_customNumber = value;
				PropertySet(this);
			}
		}

		public LcdScreenILogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
