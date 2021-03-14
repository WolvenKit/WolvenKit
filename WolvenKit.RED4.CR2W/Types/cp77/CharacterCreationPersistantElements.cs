using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterCreationPersistantElements : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _headerHolder;
		private inkWidgetReference _lBBtn;
		private inkWidgetReference _rBBtn;
		private inkCompoundWidgetReference _fluffHolderRight;
		private inkCompoundWidgetReference _fluffHolderDown;
		private inkCompoundWidgetReference _fluffHolderLeft;
		private inkTextWidgetReference _fluffText1;
		private inkTextWidgetReference _fluffTextRight;
		private inkTextWidgetReference _fluffTextDown;
		private inkTextWidgetReference _fluffTextLeft;
		private CArray<CHandle<CharacterCreationTopBarHeader>> _headers;
		private CHandle<CharacterCreationTopBarHeader> _selectedHeader;
		private CFloat _c_fluffMaxX;
		private CFloat _c_fluffMinY;
		private CFloat _c_fluffMaxY;

		[Ordinal(1)] 
		[RED("headerHolder")] 
		public inkCompoundWidgetReference HeaderHolder
		{
			get
			{
				if (_headerHolder == null)
				{
					_headerHolder = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "headerHolder", cr2w, this);
				}
				return _headerHolder;
			}
			set
			{
				if (_headerHolder == value)
				{
					return;
				}
				_headerHolder = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("LBBtn")] 
		public inkWidgetReference LBBtn
		{
			get
			{
				if (_lBBtn == null)
				{
					_lBBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "LBBtn", cr2w, this);
				}
				return _lBBtn;
			}
			set
			{
				if (_lBBtn == value)
				{
					return;
				}
				_lBBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("RBBtn")] 
		public inkWidgetReference RBBtn
		{
			get
			{
				if (_rBBtn == null)
				{
					_rBBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "RBBtn", cr2w, this);
				}
				return _rBBtn;
			}
			set
			{
				if (_rBBtn == value)
				{
					return;
				}
				_rBBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("fluffHolderRight")] 
		public inkCompoundWidgetReference FluffHolderRight
		{
			get
			{
				if (_fluffHolderRight == null)
				{
					_fluffHolderRight = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "fluffHolderRight", cr2w, this);
				}
				return _fluffHolderRight;
			}
			set
			{
				if (_fluffHolderRight == value)
				{
					return;
				}
				_fluffHolderRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fluffHolderDown")] 
		public inkCompoundWidgetReference FluffHolderDown
		{
			get
			{
				if (_fluffHolderDown == null)
				{
					_fluffHolderDown = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "fluffHolderDown", cr2w, this);
				}
				return _fluffHolderDown;
			}
			set
			{
				if (_fluffHolderDown == value)
				{
					return;
				}
				_fluffHolderDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("fluffHolderLeft")] 
		public inkCompoundWidgetReference FluffHolderLeft
		{
			get
			{
				if (_fluffHolderLeft == null)
				{
					_fluffHolderLeft = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "fluffHolderLeft", cr2w, this);
				}
				return _fluffHolderLeft;
			}
			set
			{
				if (_fluffHolderLeft == value)
				{
					return;
				}
				_fluffHolderLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get
			{
				if (_fluffText1 == null)
				{
					_fluffText1 = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffText1", cr2w, this);
				}
				return _fluffText1;
			}
			set
			{
				if (_fluffText1 == value)
				{
					return;
				}
				_fluffText1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fluffTextRight")] 
		public inkTextWidgetReference FluffTextRight
		{
			get
			{
				if (_fluffTextRight == null)
				{
					_fluffTextRight = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffTextRight", cr2w, this);
				}
				return _fluffTextRight;
			}
			set
			{
				if (_fluffTextRight == value)
				{
					return;
				}
				_fluffTextRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fluffTextDown")] 
		public inkTextWidgetReference FluffTextDown
		{
			get
			{
				if (_fluffTextDown == null)
				{
					_fluffTextDown = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffTextDown", cr2w, this);
				}
				return _fluffTextDown;
			}
			set
			{
				if (_fluffTextDown == value)
				{
					return;
				}
				_fluffTextDown = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("fluffTextLeft")] 
		public inkTextWidgetReference FluffTextLeft
		{
			get
			{
				if (_fluffTextLeft == null)
				{
					_fluffTextLeft = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "fluffTextLeft", cr2w, this);
				}
				return _fluffTextLeft;
			}
			set
			{
				if (_fluffTextLeft == value)
				{
					return;
				}
				_fluffTextLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("headers")] 
		public CArray<CHandle<CharacterCreationTopBarHeader>> Headers
		{
			get
			{
				if (_headers == null)
				{
					_headers = (CArray<CHandle<CharacterCreationTopBarHeader>>) CR2WTypeManager.Create("array:handle:CharacterCreationTopBarHeader", "headers", cr2w, this);
				}
				return _headers;
			}
			set
			{
				if (_headers == value)
				{
					return;
				}
				_headers = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("selectedHeader")] 
		public CHandle<CharacterCreationTopBarHeader> SelectedHeader
		{
			get
			{
				if (_selectedHeader == null)
				{
					_selectedHeader = (CHandle<CharacterCreationTopBarHeader>) CR2WTypeManager.Create("handle:CharacterCreationTopBarHeader", "selectedHeader", cr2w, this);
				}
				return _selectedHeader;
			}
			set
			{
				if (_selectedHeader == value)
				{
					return;
				}
				_selectedHeader = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("c_fluffMaxX")] 
		public CFloat C_fluffMaxX
		{
			get
			{
				if (_c_fluffMaxX == null)
				{
					_c_fluffMaxX = (CFloat) CR2WTypeManager.Create("Float", "c_fluffMaxX", cr2w, this);
				}
				return _c_fluffMaxX;
			}
			set
			{
				if (_c_fluffMaxX == value)
				{
					return;
				}
				_c_fluffMaxX = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("c_fluffMinY")] 
		public CFloat C_fluffMinY
		{
			get
			{
				if (_c_fluffMinY == null)
				{
					_c_fluffMinY = (CFloat) CR2WTypeManager.Create("Float", "c_fluffMinY", cr2w, this);
				}
				return _c_fluffMinY;
			}
			set
			{
				if (_c_fluffMinY == value)
				{
					return;
				}
				_c_fluffMinY = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("c_fluffMaxY")] 
		public CFloat C_fluffMaxY
		{
			get
			{
				if (_c_fluffMaxY == null)
				{
					_c_fluffMaxY = (CFloat) CR2WTypeManager.Create("Float", "c_fluffMaxY", cr2w, this);
				}
				return _c_fluffMaxY;
			}
			set
			{
				if (_c_fluffMaxY == value)
				{
					return;
				}
				_c_fluffMaxY = value;
				PropertySet(this);
			}
		}

		public CharacterCreationPersistantElements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
