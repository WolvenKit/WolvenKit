using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TraitBoughtEvent : redEvent
	{
		private CEnum<gamedataTraitType> _traitType;

		[Ordinal(0)] 
		[RED("traitType")] 
		public CEnum<gamedataTraitType> TraitType
		{
			get => GetProperty(ref _traitType);
			set => SetProperty(ref _traitType, value);
		}

		public TraitBoughtEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
