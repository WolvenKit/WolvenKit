using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkSpeedAnim : animAnimNode_SkAnim
	{
		private animFloatLink _speed;

		[Ordinal(30)] 
		[RED("Speed")] 
		public animFloatLink Speed
		{
			get
			{
				if (_speed == null)
				{
					_speed = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "Speed", cr2w, this);
				}
				return _speed;
			}
			set
			{
				if (_speed == value)
				{
					return;
				}
				_speed = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkSpeedAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
