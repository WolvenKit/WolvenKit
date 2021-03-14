using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameScanningTooltipElementData : CVariable
	{
		private TweakDBID _recordID;
		private CName _localizedName;
		private CName _localizedDescription;

		[Ordinal(0)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CName LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CName) CR2WTypeManager.Create("CName", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("localizedDescription")] 
		public CName LocalizedDescription
		{
			get
			{
				if (_localizedDescription == null)
				{
					_localizedDescription = (CName) CR2WTypeManager.Create("CName", "localizedDescription", cr2w, this);
				}
				return _localizedDescription;
			}
			set
			{
				if (_localizedDescription == value)
				{
					return;
				}
				_localizedDescription = value;
				PropertySet(this);
			}
		}

		public gameScanningTooltipElementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
