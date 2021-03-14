using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animIMotionTableProvider : ISerializable
	{
		private CInt32 _id;
		private CInt32 _parentId;
		private CEnum<animMotionTableType> _type;
		private CEnum<animMotionTableAction> _action;
		private CEnum<animParentStaticSwitchBranch> _parentStaticSwitchBranch;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CInt32) CR2WTypeManager.Create("Int32", "id", cr2w, this);
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
		[RED("parentId")] 
		public CInt32 ParentId
		{
			get
			{
				if (_parentId == null)
				{
					_parentId = (CInt32) CR2WTypeManager.Create("Int32", "parentId", cr2w, this);
				}
				return _parentId;
			}
			set
			{
				if (_parentId == value)
				{
					return;
				}
				_parentId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<animMotionTableType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<animMotionTableType>) CR2WTypeManager.Create("animMotionTableType", "type", cr2w, this);
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

		[Ordinal(3)] 
		[RED("action")] 
		public CEnum<animMotionTableAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CEnum<animMotionTableAction>) CR2WTypeManager.Create("animMotionTableAction", "action", cr2w, this);
				}
				return _action;
			}
			set
			{
				if (_action == value)
				{
					return;
				}
				_action = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("parentStaticSwitchBranch")] 
		public CEnum<animParentStaticSwitchBranch> ParentStaticSwitchBranch
		{
			get
			{
				if (_parentStaticSwitchBranch == null)
				{
					_parentStaticSwitchBranch = (CEnum<animParentStaticSwitchBranch>) CR2WTypeManager.Create("animParentStaticSwitchBranch", "parentStaticSwitchBranch", cr2w, this);
				}
				return _parentStaticSwitchBranch;
			}
			set
			{
				if (_parentStaticSwitchBranch == value)
				{
					return;
				}
				_parentStaticSwitchBranch = value;
				PropertySet(this);
			}
		}

		public animIMotionTableProvider(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
