using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UndressPlayer : redEvent
	{
		private CBool _isCensored;

		[Ordinal(0)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get
			{
				if (_isCensored == null)
				{
					_isCensored = (CBool) CR2WTypeManager.Create("Bool", "isCensored", cr2w, this);
				}
				return _isCensored;
			}
			set
			{
				if (_isCensored == value)
				{
					return;
				}
				_isCensored = value;
				PropertySet(this);
			}
		}

		public UndressPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
