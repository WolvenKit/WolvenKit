using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_CombatState : animAnimFeature
	{
		private CBool _isInCombat;

		[Ordinal(0)] 
		[RED("isInCombat")] 
		public CBool IsInCombat
		{
			get => GetProperty(ref _isInCombat);
			set => SetProperty(ref _isInCombat, value);
		}

		public AnimFeature_CombatState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
