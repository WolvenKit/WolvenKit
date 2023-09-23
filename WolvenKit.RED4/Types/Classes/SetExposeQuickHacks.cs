using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetExposeQuickHacks : ActionBool
	{
		[Ordinal(38)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SetExposeQuickHacks()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
