using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CameraDeadBodyData : IScriptable
	{
		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get => GetPropertyValue<CEnum<EGameSessionDataType>>();
			set => SetPropertyValue<CEnum<EGameSessionDataType>>(value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(2)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public CameraDeadBodyData()
		{
			OwnerID = new entEntityID();
			BodyID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
