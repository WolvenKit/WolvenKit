using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetExclusiveFocusClueEntityEvent : redEvent
	{
		private CBool _isSetExclusive;

		[Ordinal(0)] 
		[RED("isSetExclusive")] 
		public CBool IsSetExclusive
		{
			get
			{
				if (_isSetExclusive == null)
				{
					_isSetExclusive = (CBool) CR2WTypeManager.Create("Bool", "isSetExclusive", cr2w, this);
				}
				return _isSetExclusive;
			}
			set
			{
				if (_isSetExclusive == value)
				{
					return;
				}
				_isSetExclusive = value;
				PropertySet(this);
			}
		}

		public gameSetExclusiveFocusClueEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
