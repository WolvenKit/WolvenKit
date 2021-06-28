using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsvisDialogChoiceHubs : CVariable
	{
		private CArray<gameinteractionsvisListChoiceHubData> _choiceHubs;

		[Ordinal(0)] 
		[RED("choiceHubs")] 
		public CArray<gameinteractionsvisListChoiceHubData> ChoiceHubs
		{
			get => GetProperty(ref _choiceHubs);
			set => SetProperty(ref _choiceHubs, value);
		}

		public gameinteractionsvisDialogChoiceHubs(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
