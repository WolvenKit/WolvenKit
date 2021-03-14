using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
		private CInt32 _readIndex;
		private CInt32 _writeIndex;
		private CInt32 _maxSize;
		private CArray<CString> _entries;
		private inkVerticalPanelWidgetReference _panel;
		private CUInt32 _onNewEntries;
		private CUInt32 _onHide;

		[Ordinal(9)] 
		[RED("readIndex")] 
		public CInt32 ReadIndex
		{
			get
			{
				if (_readIndex == null)
				{
					_readIndex = (CInt32) CR2WTypeManager.Create("Int32", "readIndex", cr2w, this);
				}
				return _readIndex;
			}
			set
			{
				if (_readIndex == value)
				{
					return;
				}
				_readIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("writeIndex")] 
		public CInt32 WriteIndex
		{
			get
			{
				if (_writeIndex == null)
				{
					_writeIndex = (CInt32) CR2WTypeManager.Create("Int32", "writeIndex", cr2w, this);
				}
				return _writeIndex;
			}
			set
			{
				if (_writeIndex == value)
				{
					return;
				}
				_writeIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get
			{
				if (_maxSize == null)
				{
					_maxSize = (CInt32) CR2WTypeManager.Create("Int32", "maxSize", cr2w, this);
				}
				return _maxSize;
			}
			set
			{
				if (_maxSize == value)
				{
					return;
				}
				_maxSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<CString> Entries
		{
			get
			{
				if (_entries == null)
				{
					_entries = (CArray<CString>) CR2WTypeManager.Create("array:String", "entries", cr2w, this);
				}
				return _entries;
			}
			set
			{
				if (_entries == value)
				{
					return;
				}
				_entries = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get
			{
				if (_panel == null)
				{
					_panel = (inkVerticalPanelWidgetReference) CR2WTypeManager.Create("inkVerticalPanelWidgetReference", "panel", cr2w, this);
				}
				return _panel;
			}
			set
			{
				if (_panel == value)
				{
					return;
				}
				_panel = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("onNewEntries")] 
		public CUInt32 OnNewEntries
		{
			get
			{
				if (_onNewEntries == null)
				{
					_onNewEntries = (CUInt32) CR2WTypeManager.Create("Uint32", "onNewEntries", cr2w, this);
				}
				return _onNewEntries;
			}
			set
			{
				if (_onNewEntries == value)
				{
					return;
				}
				_onNewEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("onHide")] 
		public CUInt32 OnHide
		{
			get
			{
				if (_onHide == null)
				{
					_onHide = (CUInt32) CR2WTypeManager.Create("Uint32", "onHide", cr2w, this);
				}
				return _onHide;
			}
			set
			{
				if (_onHide == value)
				{
					return;
				}
				_onHide = value;
				PropertySet(this);
			}
		}

		public activityLogGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
