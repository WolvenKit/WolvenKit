using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CameraDeadBodyData : IScriptable
	{
		private CEnum<EGameSessionDataType> _dataType;
		private entEntityID _ownerID;
		private entEntityID _bodyID;

		[Ordinal(0)] 
		[RED("dataType")] 
		public CEnum<EGameSessionDataType> DataType
		{
			get => GetProperty(ref _dataType);
			set => SetProperty(ref _dataType, value);
		}

		[Ordinal(1)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(2)] 
		[RED("bodyID")] 
		public entEntityID BodyID
		{
			get => GetProperty(ref _bodyID);
			set => SetProperty(ref _bodyID, value);
		}
	}
}
