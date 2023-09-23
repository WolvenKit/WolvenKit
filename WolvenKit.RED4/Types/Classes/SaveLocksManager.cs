using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SaveLocksManager : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("saveLocks")] 
		public CArray<CName> SaveLocks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public SaveLocksManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
