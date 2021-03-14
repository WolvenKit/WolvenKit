using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CooldownRequest : IScriptable
	{
		private CHandle<BaseScriptableAction> _action;
		private CArray<PSOwnerData> _contactBook;
		private CEnum<RequestType> _requestTriggerType;

		[Ordinal(0)] 
		[RED("action")] 
		public CHandle<BaseScriptableAction> Action
		{
			get
			{
				if (_action == null)
				{
					_action = (CHandle<BaseScriptableAction>) CR2WTypeManager.Create("handle:BaseScriptableAction", "action", cr2w, this);
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

		[Ordinal(1)] 
		[RED("contactBook")] 
		public CArray<PSOwnerData> ContactBook
		{
			get
			{
				if (_contactBook == null)
				{
					_contactBook = (CArray<PSOwnerData>) CR2WTypeManager.Create("array:PSOwnerData", "contactBook", cr2w, this);
				}
				return _contactBook;
			}
			set
			{
				if (_contactBook == value)
				{
					return;
				}
				_contactBook = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("requestTriggerType")] 
		public CEnum<RequestType> RequestTriggerType
		{
			get
			{
				if (_requestTriggerType == null)
				{
					_requestTriggerType = (CEnum<RequestType>) CR2WTypeManager.Create("RequestType", "requestTriggerType", cr2w, this);
				}
				return _requestTriggerType;
			}
			set
			{
				if (_requestTriggerType == value)
				{
					return;
				}
				_requestTriggerType = value;
				PropertySet(this);
			}
		}

		public CooldownRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
