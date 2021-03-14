using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewLocationNotification : JournalNotification
	{
		private inkTextWidgetReference _districtName;
		private inkImageWidgetReference _districtIcon;
		private inkImageWidgetReference _districtFluffIcon;

		[Ordinal(16)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get
			{
				if (_districtName == null)
				{
					_districtName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "districtName", cr2w, this);
				}
				return _districtName;
			}
			set
			{
				if (_districtName == value)
				{
					return;
				}
				_districtName = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("districtIcon")] 
		public inkImageWidgetReference DistrictIcon
		{
			get
			{
				if (_districtIcon == null)
				{
					_districtIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "districtIcon", cr2w, this);
				}
				return _districtIcon;
			}
			set
			{
				if (_districtIcon == value)
				{
					return;
				}
				_districtIcon = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("districtFluffIcon")] 
		public inkImageWidgetReference DistrictFluffIcon
		{
			get
			{
				if (_districtFluffIcon == null)
				{
					_districtFluffIcon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "districtFluffIcon", cr2w, this);
				}
				return _districtFluffIcon;
			}
			set
			{
				if (_districtFluffIcon == value)
				{
					return;
				}
				_districtFluffIcon = value;
				PropertySet(this);
			}
		}

		public NewLocationNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
