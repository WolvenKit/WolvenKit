using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkBoughtEvent : redEvent
	{
		private CEnum<gamedataPerkType> _perkType;

		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		public PerkBoughtEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
