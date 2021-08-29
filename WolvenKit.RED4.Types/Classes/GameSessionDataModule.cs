using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameSessionDataModule : IScriptable
	{
		private CEnum<EGameSessionDataType> _moduleType;

		[Ordinal(0)] 
		[RED("moduleType")] 
		public CEnum<EGameSessionDataType> ModuleType
		{
			get => GetProperty(ref _moduleType);
			set => SetProperty(ref _moduleType, value);
		}
	}
}
