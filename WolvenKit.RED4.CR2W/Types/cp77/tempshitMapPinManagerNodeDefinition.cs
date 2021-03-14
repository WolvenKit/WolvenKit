using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class tempshitMapPinManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CName _mapPinName;
		private CEnum<tempshitMapPinOperation> _operation;
		private gameEntityReference _nodeRef;
		private Vector3 _position;
		private LocalizationString _forceCaption;

		[Ordinal(2)] 
		[RED("mapPinName")] 
		public CName MapPinName
		{
			get
			{
				if (_mapPinName == null)
				{
					_mapPinName = (CName) CR2WTypeManager.Create("CName", "mapPinName", cr2w, this);
				}
				return _mapPinName;
			}
			set
			{
				if (_mapPinName == value)
				{
					return;
				}
				_mapPinName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<tempshitMapPinOperation> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CEnum<tempshitMapPinOperation>) CR2WTypeManager.Create("tempshitMapPinOperation", "operation", cr2w, this);
				}
				return _operation;
			}
			set
			{
				if (_operation == value)
				{
					return;
				}
				_operation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeRef")] 
		public gameEntityReference NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("position")] 
		public Vector3 Position
		{
			get
			{
				if (_position == null)
				{
					_position = (Vector3) CR2WTypeManager.Create("Vector3", "position", cr2w, this);
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

		[Ordinal(6)] 
		[RED("forceCaption")] 
		public LocalizationString ForceCaption
		{
			get
			{
				if (_forceCaption == null)
				{
					_forceCaption = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "forceCaption", cr2w, this);
				}
				return _forceCaption;
			}
			set
			{
				if (_forceCaption == value)
				{
					return;
				}
				_forceCaption = value;
				PropertySet(this);
			}
		}

		public tempshitMapPinManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
