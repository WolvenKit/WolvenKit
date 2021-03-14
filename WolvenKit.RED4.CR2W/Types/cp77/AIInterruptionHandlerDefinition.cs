using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionHandlerDefinition : LibTreeINodeDefinition
	{
		private AIInterruptionSignal _signal;
		private CBool _supportLessImportantSignals;

		[Ordinal(0)] 
		[RED("signal")] 
		public AIInterruptionSignal Signal
		{
			get
			{
				if (_signal == null)
				{
					_signal = (AIInterruptionSignal) CR2WTypeManager.Create("AIInterruptionSignal", "signal", cr2w, this);
				}
				return _signal;
			}
			set
			{
				if (_signal == value)
				{
					return;
				}
				_signal = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("supportLessImportantSignals")] 
		public CBool SupportLessImportantSignals
		{
			get
			{
				if (_supportLessImportantSignals == null)
				{
					_supportLessImportantSignals = (CBool) CR2WTypeManager.Create("Bool", "supportLessImportantSignals", cr2w, this);
				}
				return _supportLessImportantSignals;
			}
			set
			{
				if (_supportLessImportantSignals == value)
				{
					return;
				}
				_supportLessImportantSignals = value;
				PropertySet(this);
			}
		}

		public AIInterruptionHandlerDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
