using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaCrossingPerimeter : SecurityAreaEvent
	{
		private CBool _entered;

		[Ordinal(27)] 
		[RED("entered")] 
		public CBool Entered
		{
			get
			{
				if (_entered == null)
				{
					_entered = (CBool) CR2WTypeManager.Create("Bool", "entered", cr2w, this);
				}
				return _entered;
			}
			set
			{
				if (_entered == value)
				{
					return;
				}
				_entered = value;
				PropertySet(this);
			}
		}

		public SecurityAreaCrossingPerimeter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
