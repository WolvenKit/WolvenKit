using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		private animFloatLink _durationLink;

		[Ordinal(31)] 
		[RED("durationLink")] 
		public animFloatLink DurationLink
		{
			get
			{
				if (_durationLink == null)
				{
					_durationLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "durationLink", cr2w, this);
				}
				return _durationLink;
			}
			set
			{
				if (_durationLink == value)
				{
					return;
				}
				_durationLink = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
