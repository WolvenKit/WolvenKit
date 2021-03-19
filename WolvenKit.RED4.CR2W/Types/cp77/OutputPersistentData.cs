using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OutputPersistentData : CVariable
	{
		private CEnum<ESecuritySystemState> _currentSecurityState;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CBool _securityStateChanged;
		private Vector4 _lastKnownPosition;
		private CEnum<ESecurityNotificationType> _type;
		private CEnum<ESecurityAreaType> _areaType;
		private entEntityID _objectOfInterest;
		private entEntityID _whoBreached;
		private gamePersistentID _reporter;
		private CInt32 _id;

		[Ordinal(0)] 
		[RED("currentSecurityState")] 
		public CEnum<ESecuritySystemState> CurrentSecurityState
		{
			get => GetProperty(ref _currentSecurityState);
			set => SetProperty(ref _currentSecurityState, value);
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetProperty(ref _breachOrigin);
			set => SetProperty(ref _breachOrigin, value);
		}

		[Ordinal(2)] 
		[RED("securityStateChanged")] 
		public CBool SecurityStateChanged
		{
			get => GetProperty(ref _securityStateChanged);
			set => SetProperty(ref _securityStateChanged, value);
		}

		[Ordinal(3)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetProperty(ref _lastKnownPosition);
			set => SetProperty(ref _lastKnownPosition, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ESecurityNotificationType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("areaType")] 
		public CEnum<ESecurityAreaType> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		[Ordinal(6)] 
		[RED("objectOfInterest")] 
		public entEntityID ObjectOfInterest
		{
			get => GetProperty(ref _objectOfInterest);
			set => SetProperty(ref _objectOfInterest, value);
		}

		[Ordinal(7)] 
		[RED("whoBreached")] 
		public entEntityID WhoBreached
		{
			get => GetProperty(ref _whoBreached);
			set => SetProperty(ref _whoBreached, value);
		}

		[Ordinal(8)] 
		[RED("reporter")] 
		public gamePersistentID Reporter
		{
			get => GetProperty(ref _reporter);
			set => SetProperty(ref _reporter, value);
		}

		[Ordinal(9)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public OutputPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
