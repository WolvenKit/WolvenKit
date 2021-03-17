using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectTDBPicker : CVariable
	{
		private TweakDBID _statusEffect;

		[Ordinal(0)] 
		[RED("statusEffect")] 
		public TweakDBID StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		public gameStatusEffectTDBPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
