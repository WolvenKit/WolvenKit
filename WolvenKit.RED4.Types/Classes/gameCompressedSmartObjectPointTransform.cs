using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCompressedSmartObjectPointTransform : RedBaseClass
	{
		private CUInt16 _transformId;

		[Ordinal(0)] 
		[RED("transformId")] 
		public CUInt16 TransformId
		{
			get => GetProperty(ref _transformId);
			set => SetProperty(ref _transformId, value);
		}
	}
}
