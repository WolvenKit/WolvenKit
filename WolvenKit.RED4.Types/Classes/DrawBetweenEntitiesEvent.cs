using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrawBetweenEntitiesEvent : redEvent
	{
		private CBool _shouldDraw;
		private gameFxResource _fxResource;
		private CBool _revealMaster;
		private CBool _revealSlave;
		private entEntityID _masterEntity;
		private entEntityID _slaveEntity;

		[Ordinal(0)] 
		[RED("shouldDraw")] 
		public CBool ShouldDraw
		{
			get => GetProperty(ref _shouldDraw);
			set => SetProperty(ref _shouldDraw, value);
		}

		[Ordinal(1)] 
		[RED("fxResource")] 
		public gameFxResource FxResource
		{
			get => GetProperty(ref _fxResource);
			set => SetProperty(ref _fxResource, value);
		}

		[Ordinal(2)] 
		[RED("revealMaster")] 
		public CBool RevealMaster
		{
			get => GetProperty(ref _revealMaster);
			set => SetProperty(ref _revealMaster, value);
		}

		[Ordinal(3)] 
		[RED("revealSlave")] 
		public CBool RevealSlave
		{
			get => GetProperty(ref _revealSlave);
			set => SetProperty(ref _revealSlave, value);
		}

		[Ordinal(4)] 
		[RED("masterEntity")] 
		public entEntityID MasterEntity
		{
			get => GetProperty(ref _masterEntity);
			set => SetProperty(ref _masterEntity, value);
		}

		[Ordinal(5)] 
		[RED("slaveEntity")] 
		public entEntityID SlaveEntity
		{
			get => GetProperty(ref _slaveEntity);
			set => SetProperty(ref _slaveEntity, value);
		}
	}
}
