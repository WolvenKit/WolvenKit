using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIInterruptionSignal : CVariable
	{
		private CEnum<AIEInterruptionImportance> _importance;
		private CName _signal;

		[Ordinal(0)] 
		[RED("importance")] 
		public CEnum<AIEInterruptionImportance> Importance
		{
			get
			{
				if (_importance == null)
				{
					_importance = (CEnum<AIEInterruptionImportance>) CR2WTypeManager.Create("AIEInterruptionImportance", "importance", cr2w, this);
				}
				return _importance;
			}
			set
			{
				if (_importance == value)
				{
					return;
				}
				_importance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("signal")] 
		public CName Signal
		{
			get
			{
				if (_signal == null)
				{
					_signal = (CName) CR2WTypeManager.Create("CName", "signal", cr2w, this);
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

		public AIInterruptionSignal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
