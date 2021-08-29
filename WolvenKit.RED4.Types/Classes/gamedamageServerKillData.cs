using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedamageServerKillData : IScriptable
	{
		private CUInt32 _id;
		private gameuiKillInfo _killInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("killInfo")] 
		public gameuiKillInfo KillInfo
		{
			get => GetProperty(ref _killInfo);
			set => SetProperty(ref _killInfo, value);
		}
	}
}
