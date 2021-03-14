using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsMappinEntry : CVariable
	{
		private gameNewMappinID _id;
		private CName _type;
		private Vector4 _worldPosition;

		[Ordinal(0)] 
		[RED("id")] 
		public gameNewMappinID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (gameNewMappinID) CR2WTypeManager.Create("gameNewMappinID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CName Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CName) CR2WTypeManager.Create("CName", "type", cr2w, this);
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

		[Ordinal(2)] 
		[RED("worldPosition")] 
		public Vector4 WorldPosition
		{
			get
			{
				if (_worldPosition == null)
				{
					_worldPosition = (Vector4) CR2WTypeManager.Create("Vector4", "worldPosition", cr2w, this);
				}
				return _worldPosition;
			}
			set
			{
				if (_worldPosition == value)
				{
					return;
				}
				_worldPosition = value;
				PropertySet(this);
			}
		}

		public gamemappinsMappinEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
