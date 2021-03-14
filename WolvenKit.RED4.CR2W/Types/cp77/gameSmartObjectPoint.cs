using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectPoint : CVariable
	{
		private CBool _isReachable;

		[Ordinal(0)] 
		[RED("isReachable")] 
		public CBool IsReachable
		{
			get
			{
				if (_isReachable == null)
				{
					_isReachable = (CBool) CR2WTypeManager.Create("Bool", "isReachable", cr2w, this);
				}
				return _isReachable;
			}
			set
			{
				if (_isReachable == value)
				{
					return;
				}
				_isReachable = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
