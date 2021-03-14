using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPlayerReachablePrereq : gameIScriptablePrereq
	{
		private CBool _invert;
		private CBool _checkRMA;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("checkRMA")] 
		public CBool CheckRMA
		{
			get
			{
				if (_checkRMA == null)
				{
					_checkRMA = (CBool) CR2WTypeManager.Create("Bool", "checkRMA", cr2w, this);
				}
				return _checkRMA;
			}
			set
			{
				if (_checkRMA == value)
				{
					return;
				}
				_checkRMA = value;
				PropertySet(this);
			}
		}

		public IsPlayerReachablePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
