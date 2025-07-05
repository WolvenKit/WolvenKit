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
			Id = new interopStringWithID();
			TransformInfo = new interopTransformInfo { Translation = new Vector3(), Rotation = new EulerAngles() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
