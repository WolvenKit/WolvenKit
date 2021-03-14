using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceAnimSetup : CVariable
	{
		private CFloat _animationTime;

		[Ordinal(0)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get
			{
				if (_animationTime == null)
				{
					_animationTime = (CFloat) CR2WTypeManager.Create("Float", "animationTime", cr2w, this);
				}
				return _animationTime;
			}
			set
			{
				if (_animationTime == value)
				{
					return;
				}
				_animationTime = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceAnimSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
