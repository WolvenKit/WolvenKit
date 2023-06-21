using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PatchNotesCheckData : IScriptable
	{
		[Ordinal(0)] 
		[RED("ownExpansion")] 
		public CBool OwnExpansion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PatchNotesCheckData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
