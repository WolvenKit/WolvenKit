using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeathEvents : HighLevelTransition
	{
		private CBool _isDyingEffectPlaying;

		[Ordinal(0)] 
		[RED("isDyingEffectPlaying")] 
		public CBool IsDyingEffectPlaying
		{
			get
			{
				if (_isDyingEffectPlaying == null)
				{
					_isDyingEffectPlaying = (CBool) CR2WTypeManager.Create("Bool", "isDyingEffectPlaying", cr2w, this);
				}
				return _isDyingEffectPlaying;
			}
			set
			{
				if (_isDyingEffectPlaying == value)
				{
					return;
				}
				_isDyingEffectPlaying = value;
				PropertySet(this);
			}
		}

		public DeathEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
