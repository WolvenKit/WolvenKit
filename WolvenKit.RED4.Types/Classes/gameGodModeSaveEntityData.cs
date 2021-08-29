using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameGodModeSaveEntityData : RedBaseClass
	{
		private entEntityID _entityId;
		private gameGodModeEntityData _data;

		[Ordinal(0)] 
		[RED("entityId")] 
		public entEntityID EntityId
		{
			get => GetProperty(ref _entityId);
			set => SetProperty(ref _entityId, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public gameGodModeEntityData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
