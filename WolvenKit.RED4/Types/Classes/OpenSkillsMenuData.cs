using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpenSkillsMenuData : IScriptable
	{
		[Ordinal(0)] 
		[RED("openSkills")] 
		public CBool OpenSkills
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public OpenSkillsMenuData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
