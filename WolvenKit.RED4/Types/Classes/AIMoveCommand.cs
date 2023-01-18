using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIMoveCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("removeAfterCombat")] 
		public CBool RemoveAfterCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ignoreInCombat")] 
		public CBool IgnoreInCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("alwaysUseStealth")] 
		public CBool AlwaysUseStealth
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIMoveCommand()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
