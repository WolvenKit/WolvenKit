using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class workCoverTypeCondition : workIWorkspotCondition
	{
		private CBool _isHighCover;

		[Ordinal(2)] 
		[RED("isHighCover")] 
		public CBool IsHighCover
		{
			get
			{
				if (_isHighCover == null)
				{
					_isHighCover = (CBool) CR2WTypeManager.Create("Bool", "isHighCover", cr2w, this);
				}
				return _isHighCover;
			}
			set
			{
				if (_isHighCover == value)
				{
					return;
				}
				_isHighCover = value;
				PropertySet(this);
			}
		}

		public workCoverTypeCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
