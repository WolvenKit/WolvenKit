using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGodModeSharedState : gameIGameSystemReplicatedState
	{
		private CArray<gameGodModeSharedStateData> _datas;

		[Ordinal(0)] 
		[RED("datas")] 
		public CArray<gameGodModeSharedStateData> Datas
		{
			get => GetProperty(ref _datas);
			set => SetProperty(ref _datas, value);
		}
	}
}
