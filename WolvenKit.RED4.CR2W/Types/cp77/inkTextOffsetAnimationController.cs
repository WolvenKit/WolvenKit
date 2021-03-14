using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextOffsetAnimationController : inkTextAnimationController
	{
		private CFloat _timeToSkip;

		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get
			{
				if (_timeToSkip == null)
				{
					_timeToSkip = (CFloat) CR2WTypeManager.Create("Float", "timeToSkip", cr2w, this);
				}
				return _timeToSkip;
			}
			set
			{
				if (_timeToSkip == value)
				{
					return;
				}
				_timeToSkip = value;
				PropertySet(this);
			}
		}

		public inkTextOffsetAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
