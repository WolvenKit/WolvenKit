using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithSpeedAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _speedLink;

		[Ordinal(31)] 
		[RED("speedLink")] 
		public animFloatLink SpeedLink
		{
			get
			{
				if (_speedLink == null)
				{
					_speedLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "speedLink", cr2w, this);
				}
				return _speedLink;
			}
			set
			{
				if (_speedLink == value)
				{
					return;
				}
				_speedLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkPhaseWithSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
