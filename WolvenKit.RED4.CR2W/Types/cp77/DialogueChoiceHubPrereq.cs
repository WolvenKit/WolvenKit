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
			get
			{
				if (_isChoiceHubActive == null)
				{
					_isChoiceHubActive = (CBool) CR2WTypeManager.Create("Bool", "isChoiceHubActive", cr2w, this);
				}
				return _isChoiceHubActive;
			}
			set
			{
				if (_isChoiceHubActive == value)
				{
					return;
				}
				_isChoiceHubActive = value;
				PropertySet(this);
			}
		}

		public DialogueChoiceHubPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
