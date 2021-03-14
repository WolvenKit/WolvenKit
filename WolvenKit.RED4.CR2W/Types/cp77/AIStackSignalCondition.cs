using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIStackSignalCondition : AIbehaviorStackScriptPassiveExpressionDefinition
	{
		private CName _signalName;

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

		public AIStackSignalCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
