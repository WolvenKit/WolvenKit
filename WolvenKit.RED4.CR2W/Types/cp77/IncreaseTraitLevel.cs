using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IncreaseTraitLevel : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataTraitType> _trait;

		[Ordinal(1)] 
		[RED("trait")] 
		public CEnum<gamedataTraitType> Trait
		{
			get => GetProperty(ref _trait);
			set => SetProperty(ref _trait, value);
		}

		public IncreaseTraitLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
