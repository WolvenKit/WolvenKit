using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CurrentStanceNPCStatePrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataNPCStanceState> _valueToCheck;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("valueToCheck")] 
		public CEnum<gamedataNPCStanceState> ValueToCheck
		{
			get
			{
				if (_valueToCheck == null)
				{
					_valueToCheck = (CEnum<gamedataNPCStanceState>) CR2WTypeManager.Create("gamedataNPCStanceState", "valueToCheck", cr2w, this);
				}
				return _valueToCheck;
			}
			set
			{
				if (_valueToCheck == value)
				{
					return;
				}
				_valueToCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public CurrentStanceNPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
