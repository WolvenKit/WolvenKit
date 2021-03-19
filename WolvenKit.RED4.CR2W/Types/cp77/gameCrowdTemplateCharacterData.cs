using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateCharacterData : CVariable
	{
		private TweakDBID _characterRecordId;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		public gameCrowdTemplateCharacterData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
