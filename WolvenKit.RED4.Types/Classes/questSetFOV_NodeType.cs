using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetFOV_NodeType : questISceneManagerNodeType
	{
		private CFloat _fOV;

		[Ordinal(0)] 
		[RED("FOV")] 
		public CFloat FOV
		{
			get => GetProperty(ref _fOV);
			set => SetProperty(ref _fOV, value);
		}
	}
}
