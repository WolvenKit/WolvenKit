using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipModRecordData : MinimalItemTooltipModData
	{
		private CHandle<gameUILocalizationDataPackage> _dataPackage;
		private CString _description;

		[Ordinal(0)] 
		[RED("dataPackage")] 
		public CHandle<gameUILocalizationDataPackage> DataPackage
		{
			get
			{
				if (_dataPackage == null)
				{
					_dataPackage = (CHandle<gameUILocalizationDataPackage>) CR2WTypeManager.Create("handle:gameUILocalizationDataPackage", "dataPackage", cr2w, this);
				}
				return _dataPackage;
			}
			set
			{
				if (_dataPackage == value)
				{
					return;
				}
				_dataPackage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		public MinimalItemTooltipModRecordData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
