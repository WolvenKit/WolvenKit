using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get => GetPropertyValue<CHandle<gamePersistentState>>();
			set => SetPropertyValue<CHandle<gamePersistentState>>(value);
		}

		public gameComponent()
		{
			Name = "Component";
		}
	}
}
