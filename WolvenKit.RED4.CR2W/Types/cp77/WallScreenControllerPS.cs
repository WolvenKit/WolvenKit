using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WallScreenControllerPS : TVControllerPS
	{
		private CBool _isShown;

		[Ordinal(113)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get
			{
				if (_isShown == null)
				{
					_isShown = (CBool) CR2WTypeManager.Create("Bool", "isShown", cr2w, this);
				}
				return _isShown;
			}
			set
			{
				if (_isShown == value)
				{
					return;
				}
				_isShown = value;
				PropertySet(this);
			}
		}

		public WallScreenControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
