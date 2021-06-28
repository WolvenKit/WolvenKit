using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaData : CVariable
	{
		private wCHandle<SecurityAreaControllerPS> _securityArea;
		private CEnum<ESecurityAreaType> _securityAreaType;
		private CEnum<ESecurityAccessLevel> _accessLevel;
		private CString _zoneName;
		private CBool _entered;
		private gamePersistentID _id;
		private CEnum<EFilterType> _incomingFilters;
		private CEnum<EFilterType> _outgoingFilters;

		[Ordinal(0)] 
		[RED("securityArea")] 
		public wCHandle<SecurityAreaControllerPS> SecurityArea
		{
			get => GetProperty(ref _securityArea);
			set => SetProperty(ref _securityArea, value);
		}

		[Ordinal(1)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetProperty(ref _securityAreaType);
			set => SetProperty(ref _securityAreaType, value);
		}

		[Ordinal(2)] 
		[RED("accessLevel")] 
		public CEnum<ESecurityAccessLevel> AccessLevel
		{
			get => GetProperty(ref _accessLevel);
			set => SetProperty(ref _accessLevel, value);
		}

		[Ordinal(3)] 
		[RED("zoneName")] 
		public CString ZoneName
		{
			get => GetProperty(ref _zoneName);
			set => SetProperty(ref _zoneName, value);
		}

		[Ordinal(4)] 
		[RED("entered")] 
		public CBool Entered
		{
			get => GetProperty(ref _entered);
			set => SetProperty(ref _entered, value);
		}

		[Ordinal(5)] 
		[RED("id")] 
		public gamePersistentID Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(6)] 
		[RED("incomingFilters")] 
		public CEnum<EFilterType> IncomingFilters
		{
			get => GetProperty(ref _incomingFilters);
			set => SetProperty(ref _incomingFilters, value);
		}

		[Ordinal(7)] 
		[RED("outgoingFilters")] 
		public CEnum<EFilterType> OutgoingFilters
		{
			get => GetProperty(ref _outgoingFilters);
			set => SetProperty(ref _outgoingFilters, value);
		}

		public SecurityAreaData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
