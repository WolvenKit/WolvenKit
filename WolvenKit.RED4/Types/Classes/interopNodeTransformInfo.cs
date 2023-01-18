using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class interopNodeTransformInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("id")] 
		public interopStringWithID Id
		{
			get => GetPropertyValue<interopStringWithID>();
			set => SetPropertyValue<interopStringWithID>(value);
		}

		[Ordinal(1)] 
		[RED("transformInfo")] 
		public interopTransformInfo TransformInfo
		{
			get => GetPropertyValue<interopTransformInfo>();
			set => SetPropertyValue<interopTransformInfo>(value);
		}

		public interopNodeTransformInfo()
		{
			Id = new();
			TransformInfo = new() { Translation = new(), Rotation = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
