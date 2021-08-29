using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameinteractionsSetEnableEvent : redEvent
	{
		private CBool _enable;
		private CName _linkedLayers;
		private CName _layer;

		[Ordinal(0)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetProperty(ref _enable);
			set => SetProperty(ref _enable, value);
		}

		[Ordinal(1)] 
		[RED("linkedLayers")] 
		public CName LinkedLayers
		{
			get => GetProperty(ref _linkedLayers);
			set => SetProperty(ref _linkedLayers, value);
		}

		[Ordinal(2)] 
		[RED("layer")] 
		public CName Layer
		{
			get => GetProperty(ref _layer);
			set => SetProperty(ref _layer, value);
		}
	}
}
