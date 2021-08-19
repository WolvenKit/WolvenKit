using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProximityDetector : Device
	{
		private CName _scanningAreaName;
		private CName _surroundingAreaName;
		private CHandle<gameStaticTriggerAreaComponent> _scanningArea;
		private CHandle<gameStaticTriggerAreaComponent> _surroundingArea;
		private CEnum<ESecurityAreaType> _securityAreaType;
		private CEnum<ESecurityNotificationType> _notifiactionType;

		[Ordinal(87)] 
		[RED("scanningAreaName")] 
		public CName ScanningAreaName
		{
			get => GetProperty(ref _scanningAreaName);
			set => SetProperty(ref _scanningAreaName, value);
		}

		[Ordinal(88)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetProperty(ref _surroundingAreaName);
			set => SetProperty(ref _surroundingAreaName, value);
		}

		[Ordinal(89)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get => GetProperty(ref _scanningArea);
			set => SetProperty(ref _scanningArea, value);
		}

		[Ordinal(90)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetProperty(ref _surroundingArea);
			set => SetProperty(ref _surroundingArea, value);
		}

		[Ordinal(91)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetProperty(ref _securityAreaType);
			set => SetProperty(ref _securityAreaType, value);
		}

		[Ordinal(92)] 
		[RED("notifiactionType")] 
		public CEnum<ESecurityNotificationType> NotifiactionType
		{
			get => GetProperty(ref _notifiactionType);
			set => SetProperty(ref _notifiactionType, value);
		}

		public ProximityDetector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
