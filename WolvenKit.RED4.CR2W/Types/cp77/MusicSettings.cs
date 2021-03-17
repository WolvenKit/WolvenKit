using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MusicSettings : IScriptable
	{
		private CEnum<ESoundStatusEffects> _statusEffect;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public CEnum<ESoundStatusEffects> StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		public MusicSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
