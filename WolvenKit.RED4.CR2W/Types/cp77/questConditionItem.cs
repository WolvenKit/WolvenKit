using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questConditionItem : CVariable
	{
		private CHandle<questIBaseCondition> _condition;
		private CUInt32 _socketId;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("socketId")] 
		public CUInt32 SocketId
		{
			get
			{
				if (_socketId == null)
				{
					_socketId = (CUInt32) CR2WTypeManager.Create("Uint32", "socketId", cr2w, this);
				}
				return _socketId;
			}
			set
			{
				if (_socketId == value)
				{
					return;
				}
				_socketId = value;
				PropertySet(this);
			}
		}

		public questConditionItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
