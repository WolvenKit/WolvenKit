using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class interopNodeTransformInfo : RedBaseClass
	{
		private interopStringWithID _id;
		private interopTransformInfo _transformInfo;

		[Ordinal(0)] 
		[RED("id")] 
		public interopStringWithID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("transformInfo")] 
		public interopTransformInfo TransformInfo
		{
			get => GetProperty(ref _transformInfo);
			set => SetProperty(ref _transformInfo, value);
		}
	}
}
