using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAdditionalTransformEntry : ISerializable
	{
		private animTransformInfo _transformInfo;
		private QsTransform _value;

		[Ordinal(0)] 
		[RED("transformInfo")] 
		public animTransformInfo TransformInfo
		{
			get => GetProperty(ref _transformInfo);
			set => SetProperty(ref _transformInfo, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public QsTransform Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
