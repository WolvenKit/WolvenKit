using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraDeadBodyData : IScriptable
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

		public CameraDeadBodyData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
