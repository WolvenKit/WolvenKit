using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EquippedQuickHackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("programEntries")] 
		public CArray<CHandle<ProgramEntry>> ProgramEntries
		{
			get => GetPropertyValue<CArray<CHandle<ProgramEntry>>>();
			set => SetPropertyValue<CArray<CHandle<ProgramEntry>>>(value);
		}

		public EquippedQuickHackData()
		{
			ProgramEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
