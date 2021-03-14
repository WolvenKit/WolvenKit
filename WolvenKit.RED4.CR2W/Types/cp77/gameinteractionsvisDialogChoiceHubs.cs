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
			get
			{
				if (_choiceHubs == null)
				{
					_choiceHubs = (CArray<gameinteractionsvisListChoiceHubData>) CR2WTypeManager.Create("array:gameinteractionsvisListChoiceHubData", "choiceHubs", cr2w, this);
				}
				return _choiceHubs;
			}
			set
			{
				if (_choiceHubs == value)
				{
					return;
				}
				_choiceHubs = value;
				PropertySet(this);
			}
		}

		public gameinteractionsvisDialogChoiceHubs(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
