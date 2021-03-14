using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICommand : IScriptable
	{
		private CUInt32 _id;
		private CEnum<AICommandState> _state;
		private CUInt64 _questBlockId;
		private CName _category;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CUInt32) CR2WTypeManager.Create("Uint32", "id", cr2w, this);
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
		[RED("state")] 
		public CEnum<AICommandState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<AICommandState>) CR2WTypeManager.Create("AICommandState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("questBlockId")] 
		public CUInt64 QuestBlockId
		{
			get
			{
				if (_questBlockId == null)
				{
					_questBlockId = (CUInt64) CR2WTypeManager.Create("Uint64", "questBlockId", cr2w, this);
				}
				return _questBlockId;
			}
			set
			{
				if (_questBlockId == value)
				{
					return;
				}
				_questBlockId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("category")] 
		public CName Category
		{
			get
			{
				if (_category == null)
				{
					_category = (CName) CR2WTypeManager.Create("CName", "category", cr2w, this);
				}
				return _category;
			}
			set
			{
				if (_category == value)
				{
					return;
				}
				_category = value;
				PropertySet(this);
			}
		}

		public AICommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
