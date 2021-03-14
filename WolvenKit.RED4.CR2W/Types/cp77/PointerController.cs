using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PointerController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _connectors;
		private inkWidgetReference _pointer;
		private inkWidgetReference _centerButtonSlot;
		private wCHandle<inkWidget> _centerButton;
		private CInt32 _currentIndex;

		[Ordinal(1)] 
		[RED("connectors")] 
		public CArray<inkWidgetReference> Connectors
		{
			get
			{
				if (_connectors == null)
				{
					_connectors = (CArray<inkWidgetReference>) CR2WTypeManager.Create("array:inkWidgetReference", "connectors", cr2w, this);
				}
				return _connectors;
			}
			set
			{
				if (_connectors == value)
				{
					return;
				}
				_connectors = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("pointer")] 
		public inkWidgetReference Pointer
		{
			get
			{
				if (_pointer == null)
				{
					_pointer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pointer", cr2w, this);
				}
				return _pointer;
			}
			set
			{
				if (_pointer == value)
				{
					return;
				}
				_pointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("centerButtonSlot")] 
		public inkWidgetReference CenterButtonSlot
		{
			get
			{
				if (_centerButtonSlot == null)
				{
					_centerButtonSlot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "centerButtonSlot", cr2w, this);
				}
				return _centerButtonSlot;
			}
			set
			{
				if (_centerButtonSlot == value)
				{
					return;
				}
				_centerButtonSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("centerButton")] 
		public wCHandle<inkWidget> CenterButton
		{
			get
			{
				if (_centerButton == null)
				{
					_centerButton = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "centerButton", cr2w, this);
				}
				return _centerButton;
			}
			set
			{
				if (_centerButton == value)
				{
					return;
				}
				_centerButton = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get
			{
				if (_currentIndex == null)
				{
					_currentIndex = (CInt32) CR2WTypeManager.Create("Int32", "currentIndex", cr2w, this);
				}
				return _currentIndex;
			}
			set
			{
				if (_currentIndex == value)
				{
					return;
				}
				_currentIndex = value;
				PropertySet(this);
			}
		}

		public PointerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
