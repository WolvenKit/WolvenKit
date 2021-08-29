using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSmartObjectTransformDictionary : ISerializable
	{
		private CArray<gameSmartObjectTransformDictionaryTransformEntry> _transforms;

		[Ordinal(0)] 
		[RED("transforms")] 
		public CArray<gameSmartObjectTransformDictionaryTransformEntry> Transforms
		{
			get => GetProperty(ref _transforms);
			set => SetProperty(ref _transforms, value);
		}
	}
}
