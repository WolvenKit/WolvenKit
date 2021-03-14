using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighestPrioritySignalCondition : AIbehaviorexpressionScript
	{
		private CName _signalName;
		private CUInt32 _cbId;
		private CBool _lastValue;

		[Ordinal(0)] 
		[RED("signalName")] 
		public CName SignalName
		{
			get
			{
				if (_signalName == null)
				{
					_signalName = (CName) CR2WTypeManager.Create("CName", "signalName", cr2w, this);
				}
				return _signalName;
			}
			set
			{
				if (_signalName == value)
				{
					return;
				}
				_signalName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("cbId")] 
		public CUInt32 CbId
		{
			get
			{
				if (_cbId == null)
				{
					_cbId = (CUInt32) CR2WTypeManager.Create("Uint32", "cbId", cr2w, this);
				}
				return _cbId;
			}
			set
			{
				if (_cbId == value)
				{
					return;
				}
				_cbId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public HighestPrioritySignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
