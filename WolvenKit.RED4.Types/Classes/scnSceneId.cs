using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneId : RedBaseClass
	{
		private CUInt64 _resPathHash;

		[Ordinal(0)] 
		[RED("resPathHash")] 
		public CUInt64 ResPathHash
		{
			get => GetProperty(ref _resPathHash);
			set => SetProperty(ref _resPathHash, value);
		}
	}
}
