using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCRarityPrereq : gameIScriptablePrereq
	{
		private CEnum<gamedataNPCRarity> _rarity;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		public NPCRarityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
