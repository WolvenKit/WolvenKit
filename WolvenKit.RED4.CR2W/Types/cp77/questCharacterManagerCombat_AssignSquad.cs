using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_AssignSquad : questICharacterManagerCombat_NodeSubType
	{
		private TweakDBID _presetID;
		private gameEntityReference _puppetRef;
		private CEnum<AISquadType> _squadType;

		[Ordinal(0)] 
		[RED("presetID")] 
		public TweakDBID PresetID
		{
			get => GetProperty(ref _presetID);
			set => SetProperty(ref _presetID, value);
		}

		[Ordinal(1)] 
		[RED("puppetRef")] 
		public gameEntityReference PuppetRef
		{
			get => GetProperty(ref _puppetRef);
			set => SetProperty(ref _puppetRef, value);
		}

		[Ordinal(2)] 
		[RED("squadType")] 
		public CEnum<AISquadType> SquadType
		{
			get => GetProperty(ref _squadType);
			set => SetProperty(ref _squadType, value);
		}

		public questCharacterManagerCombat_AssignSquad(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
