using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimSequenceTargetInfo : ISerializable
	{
		private CArray<CUInt32> _path;

		[Ordinal(0)] 
		[RED("path")] 
		public CArray<CUInt32> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}
	}
}
