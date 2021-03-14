using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalConditionData : CVariable
	{
		private CUInt32 _callbackId;
		private CBool _lastValue;

		[Ordinal(0)] 
		[RED("callbackId")] 
		public CUInt32 CallbackId
		{
			get
			{
				if (_callbackId == null)
				{
					_callbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "callbackId", cr2w, this);
				}
				return _callbackId;
			}
			set
			{
				if (_callbackId == value)
				{
					return;
				}
				_callbackId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastValue")] 
		public CBool LastValue
		{
			get
			{
				if (_lastValue == null)
				{
					_lastValue = (CBool) CR2WTypeManager.Create("Bool", "lastValue", cr2w, this);
				}
				return _lastValue;
			}
			set
			{
				if (_lastValue == value)
				{
					return;
				}
				_lastValue = value;
				PropertySet(this);
			}
		}

		public AIStackSignalConditionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
