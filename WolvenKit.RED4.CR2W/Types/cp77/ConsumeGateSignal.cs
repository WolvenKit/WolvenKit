using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConsumeGateSignal : GateSignal
	{
		private CName _consumeCallName;
		private CHandle<GateSignal> _signalToConsume;

		[Ordinal(4)] 
		[RED("consumeCallName")] 
		public CName ConsumeCallName
		{
			get
			{
				if (_consumeCallName == null)
				{
					_consumeCallName = (CName) CR2WTypeManager.Create("CName", "consumeCallName", cr2w, this);
				}
				return _consumeCallName;
			}
			set
			{
				if (_consumeCallName == value)
				{
					return;
				}
				_consumeCallName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("signalToConsume")] 
		public CHandle<GateSignal> SignalToConsume
		{
			get
			{
				if (_signalToConsume == null)
				{
					_signalToConsume = (CHandle<GateSignal>) CR2WTypeManager.Create("handle:GateSignal", "signalToConsume", cr2w, this);
				}
				return _signalToConsume;
			}
			set
			{
				if (_signalToConsume == value)
				{
					return;
				}
				_signalToConsume = value;
				PropertySet(this);
			}
		}

		public ConsumeGateSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
