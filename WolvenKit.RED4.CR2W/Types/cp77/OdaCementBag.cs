using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OdaCementBag : InteractiveDevice
	{
		private CBool _onCooldown;

		[Ordinal(93)] 
		[RED("onCooldown")] 
		public CBool OnCooldown
		{
			get
			{
				if (_onCooldown == null)
				{
					_onCooldown = (CBool) CR2WTypeManager.Create("Bool", "onCooldown", cr2w, this);
				}
				return _onCooldown;
			}
			set
			{
				if (_onCooldown == value)
				{
					return;
				}
				_onCooldown = value;
				PropertySet(this);
			}
		}

		public OdaCementBag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
