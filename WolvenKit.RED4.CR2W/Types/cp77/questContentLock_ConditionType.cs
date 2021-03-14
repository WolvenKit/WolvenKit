using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questContentLock_ConditionType : questIContentConditionType
	{
		private CBool _isContentBlocked;

		[Ordinal(0)] 
		[RED("isContentBlocked")] 
		public CBool IsContentBlocked
		{
			get
			{
				if (_isContentBlocked == null)
				{
					_isContentBlocked = (CBool) CR2WTypeManager.Create("Bool", "isContentBlocked", cr2w, this);
				}
				return _isContentBlocked;
			}
			set
			{
				if (_isContentBlocked == value)
				{
					return;
				}
				_isContentBlocked = value;
				PropertySet(this);
			}
		}

		public questContentLock_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
