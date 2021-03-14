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

		[Ordinal(86)] 
		[RED("scanningAreaName")] 
		public CName ScanningAreaName
		{
			get
			{
				if (_scanningAreaName == null)
				{
					_scanningAreaName = (CName) CR2WTypeManager.Create("CName", "scanningAreaName", cr2w, this);
				}
				return _scanningAreaName;
			}
			set
			{
				if (_scanningAreaName == value)
				{
					return;
				}
				_scanningAreaName = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get
			{
				if (_surroundingAreaName == null)
				{
					_surroundingAreaName = (CName) CR2WTypeManager.Create("CName", "surroundingAreaName", cr2w, this);
				}
				return _surroundingAreaName;
			}
			set
			{
				if (_surroundingAreaName == value)
				{
					return;
				}
				_surroundingAreaName = value;
				PropertySet(this);
			}
		}

		[Ordinal(88)] 
		[RED("scanningArea")] 
		public CHandle<gameStaticTriggerAreaComponent> ScanningArea
		{
			get
			{
				if (_scanningArea == null)
				{
					_scanningArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "scanningArea", cr2w, this);
				}
				return _scanningArea;
			}
			set
			{
				if (_scanningArea == value)
				{
					return;
				}
				_scanningArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(89)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get
			{
				if (_surroundingArea == null)
				{
					_surroundingArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "surroundingArea", cr2w, this);
				}
				return _surroundingArea;
			}
			set
			{
				if (_surroundingArea == value)
				{
					return;
				}
				_surroundingArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(90)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get
			{
				if (_securityAreaType == null)
				{
					_securityAreaType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "securityAreaType", cr2w, this);
				}
				return _securityAreaType;
			}
			set
			{
				if (_securityAreaType == value)
				{
					return;
				}
				_securityAreaType = value;
				PropertySet(this);
			}
		}

		[Ordinal(91)] 
		[RED("notifiactionType")] 
		public CEnum<ESecurityNotificationType> NotifiactionType
		{
			get
			{
				if (_notifiactionType == null)
				{
					_notifiactionType = (CEnum<ESecurityNotificationType>) CR2WTypeManager.Create("ESecurityNotificationType", "notifiactionType", cr2w, this);
				}
				return _notifiactionType;
			}
			set
			{
				if (_notifiactionType == value)
				{
					return;
				}
				_notifiactionType = value;
				PropertySet(this);
			}
		}

		public ProximityDetector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
