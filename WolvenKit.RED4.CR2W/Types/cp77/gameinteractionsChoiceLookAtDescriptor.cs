using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsChoiceLookAtDescriptor : CVariable
	{
		private CEnum<gameinteractionsChoiceLookAtType> _type;
		private CName _slotName;
		private Vector3 _offset;
		private gameinteractionsOrbID _orbId;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameinteractionsChoiceLookAtType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<gameinteractionsChoiceLookAtType>) CR2WTypeManager.Create("gameinteractionsChoiceLookAtType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("orbId")] 
		public gameinteractionsOrbID OrbId
		{
			get
			{
				if (_orbId == null)
				{
					_orbId = (gameinteractionsOrbID) CR2WTypeManager.Create("gameinteractionsOrbID", "orbId", cr2w, this);
				}
				return _orbId;
			}
			set
			{
				if (_orbId == value)
				{
					return;
				}
				_orbId = value;
				PropertySet(this);
			}
		}

		public gameinteractionsChoiceLookAtDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
