using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LineSpawnData : IScriptable
	{
		[Ordinal(0)] 
		[RED("lineData")] 
		public scnDialogLineData LineData
		{
			get => GetPropertyValue<scnDialogLineData>();
			set => SetPropertyValue<scnDialogLineData>(value);
		}

		public LineSpawnData()
		{
			LineData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
