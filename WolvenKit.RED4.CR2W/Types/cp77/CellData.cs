using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CellData : CVariable
	{
		private Vector2 _position;
		private ElementData _element;
		private SpecialProperties _properties;
		private wCHandle<NetworkMinigameGridCellController> _assignedCell;
		private CBool _consumed;

		[Ordinal(0)] 
		[RED("position")] 
		public Vector2 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector2) CR2WTypeManager.Create("Vector2", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("element")] 
		public ElementData Element
		{
			get
			{
				if (_element == null)
				{
					_element = (ElementData) CR2WTypeManager.Create("ElementData", "element", cr2w, this);
				}
				return _element;
			}
			set
			{
				if (_element == value)
				{
					return;
				}
				_element = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("properties")] 
		public SpecialProperties Properties
		{
			get
			{
				if (_properties == null)
				{
					_properties = (SpecialProperties) CR2WTypeManager.Create("SpecialProperties", "properties", cr2w, this);
				}
				return _properties;
			}
			set
			{
				if (_properties == value)
				{
					return;
				}
				_properties = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("assignedCell")] 
		public wCHandle<NetworkMinigameGridCellController> AssignedCell
		{
			get
			{
				if (_assignedCell == null)
				{
					_assignedCell = (wCHandle<NetworkMinigameGridCellController>) CR2WTypeManager.Create("whandle:NetworkMinigameGridCellController", "assignedCell", cr2w, this);
				}
				return _assignedCell;
			}
			set
			{
				if (_assignedCell == value)
				{
					return;
				}
				_assignedCell = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("consumed")] 
		public CBool Consumed
		{
			get
			{
				if (_consumed == null)
				{
					_consumed = (CBool) CR2WTypeManager.Create("Bool", "consumed", cr2w, this);
				}
				return _consumed;
			}
			set
			{
				if (_consumed == value)
				{
					return;
				}
				_consumed = value;
				PropertySet(this);
			}
		}

		public CellData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
