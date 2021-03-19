using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsRemoveStatusEffect : gameeventsStatusEffectEvent
	{
		private CBool _isFinalRemoval;

		[Ordinal(2)] 
		[RED("isFinalRemoval")] 
		public CBool IsFinalRemoval
		{
			get => GetProperty(ref _isFinalRemoval);
			set => SetProperty(ref _isFinalRemoval, value);
		}

		public gameeventsRemoveStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
