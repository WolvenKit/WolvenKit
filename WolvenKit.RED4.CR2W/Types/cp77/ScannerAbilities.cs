using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerAbilities : ScannerChunk
	{
		private CArray<wCHandle<gamedataGameplayAbility_Record>> _abilities;

		[Ordinal(0)] 
		[RED("abilities")] 
		public CArray<wCHandle<gamedataGameplayAbility_Record>> Abilities
		{
			get => GetProperty(ref _abilities);
			set => SetProperty(ref _abilities, value);
		}

		public ScannerAbilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
