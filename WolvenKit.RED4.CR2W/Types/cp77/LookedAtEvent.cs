using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LookedAtEvent : redEvent
	{
		private CBool _isLookedAt;

		[Ordinal(0)] 
		[RED("isLookedAt")] 
		public CBool IsLookedAt
		{
			get
			{
				if (_isLookedAt == null)
				{
					_isLookedAt = (CBool) CR2WTypeManager.Create("Bool", "isLookedAt", cr2w, this);
				}
				return _isLookedAt;
			}
			set
			{
				if (_isLookedAt == value)
				{
					return;
				}
				_isLookedAt = value;
				PropertySet(this);
			}
		}

		public LookedAtEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
