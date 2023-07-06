using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITriggerDestructionComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("startActive")] 
		public CBool StartActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameITriggerDestructionComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
