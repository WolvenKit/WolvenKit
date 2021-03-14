using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatCheckPrereq : gamePlayerScriptableSystemRequest
	{
		private CBool _register;
		private CHandle<StatCheckPrereqState> _statCheckState;

		[Ordinal(1)] 
		[RED("register")] 
		public CBool Register
		{
			get
			{
				if (_register == null)
				{
					_register = (CBool) CR2WTypeManager.Create("Bool", "register", cr2w, this);
				}
				return _register;
			}
			set
			{
				if (_register == value)
				{
					return;
				}
				_register = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("statCheckState")] 
		public CHandle<StatCheckPrereqState> StatCheckState
		{
			get
			{
				if (_statCheckState == null)
				{
					_statCheckState = (CHandle<StatCheckPrereqState>) CR2WTypeManager.Create("handle:StatCheckPrereqState", "statCheckState", cr2w, this);
				}
				return _statCheckState;
			}
			set
			{
				if (_statCheckState == value)
				{
					return;
				}
				_statCheckState = value;
				PropertySet(this);
			}
		}

		public ModifyStatCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
