using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEnterVisionMode_NodeType : questIVisionModeNodeType
	{
		private gameEntityReference _objectRef;
		private CEnum<gameVisionModeType> _visionModeType;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("visionModeType")] 
		public CEnum<gameVisionModeType> VisionModeType
		{
			get => GetProperty(ref _visionModeType);
			set => SetProperty(ref _visionModeType, value);
		}

		public questEnterVisionMode_NodeType()
		{
			_visionModeType = new() { Value = Enums.gameVisionModeType.Focus };
		}
	}
}
