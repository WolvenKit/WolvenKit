using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTimeDilation_World : questTimeDilation_NodeTypeParam
	{
		private CName _reason;
		private CHandle<questTimeDilation_Operation> _operation;

		[Ordinal(0)] 
		[RED("reason")] 
		public CName Reason
		{
			get
			{
				if (_reason == null)
				{
					_reason = (CName) CR2WTypeManager.Create("CName", "reason", cr2w, this);
				}
				return _reason;
			}
			set
			{
				if (_reason == value)
				{
					return;
				}
				_reason = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("operation")] 
		public CHandle<questTimeDilation_Operation> Operation
		{
			get
			{
				if (_operation == null)
				{
					_operation = (CHandle<questTimeDilation_Operation>) CR2WTypeManager.Create("handle:questTimeDilation_Operation", "operation", cr2w, this);
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

		public questTimeDilation_World(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
