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
			get => GetProperty(ref _isDyingEffectPlaying);
			set => SetProperty(ref _isDyingEffectPlaying, value);
		}

		public DeathEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
