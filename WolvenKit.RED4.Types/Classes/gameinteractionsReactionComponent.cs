using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameinteractionsReactionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("reactions")] 
		public CArray<gameinteractionsReactionData> Reactions
		{
			get => GetPropertyValue<CArray<gameinteractionsReactionData>>();
			set => SetPropertyValue<CArray<gameinteractionsReactionData>>(value);
		}

		[Ordinal(4)] 
		[RED("triggerAutomatically")] 
		public CBool TriggerAutomatically
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameinteractionsReactionComponent()
		{
			Name = "Component";
			Reactions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
