using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class workSequence : workIContainerEntry
	{
		[Ordinal(4)] 
		[RED("previousLoopInfinitely")] 
		public CBool PreviousLoopInfinitely
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("loopInfinitely")] 
		public CBool LoopInfinitely
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("category")] 
		public CEnum<gamedataWorkspotCategory> Category
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotCategory>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotCategory>>(value);
		}

		public workSequence()
		{
			Id = new() { Id = 4294967295 };
			List = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
