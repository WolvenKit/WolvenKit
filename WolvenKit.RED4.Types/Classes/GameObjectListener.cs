using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameObjectListener : IScriptable
	{
		[Ordinal(0)] 
		[RED("prereqOwner")] 
		public CHandle<gamePrereqState> PrereqOwner
		{
			get => GetPropertyValue<CHandle<gamePrereqState>>();
			set => SetPropertyValue<CHandle<gamePrereqState>>(value);
		}

		[Ordinal(1)] 
		[RED("e3HackBlock")] 
		public CBool E3HackBlock
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GameObjectListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
