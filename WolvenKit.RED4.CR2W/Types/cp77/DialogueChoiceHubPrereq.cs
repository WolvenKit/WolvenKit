using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DialogueChoiceHubPrereq : gameIScriptablePrereq
	{
		private CBool _isChoiceHubActive;

		[Ordinal(0)] 
		[RED("isChoiceHubActive")] 
		public CBool IsChoiceHubActive
		{
			get => GetProperty(ref _isChoiceHubActive);
			set => SetProperty(ref _isChoiceHubActive, value);
		}

		public DialogueChoiceHubPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
