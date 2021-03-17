using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterButtonItemController : inkButtonDpadSupportedController
	{
		private TweakDBID _characterRecordId;

		[Ordinal(26)] 
		[RED("characterRecordId")] 
		public TweakDBID CharacterRecordId
		{
			get => GetProperty(ref _characterRecordId);
			set => SetProperty(ref _characterRecordId, value);
		}

		public CpoCharacterButtonItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
