using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStreetNameSignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _streetName;
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _subdistrictName;

		[Ordinal(1)] 
		[RED("streetName")] 
		public inkTextWidgetReference StreetName
		{
			get
			{
				if (_streetName == null)
				{
					_streetName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "streetName", cr2w, this);
				}
				return _streetName;
			}
			set
			{
				if (_streetName == value)
				{
					return;
				}
				_streetName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("subdistrictName")] 
		public inkTextWidgetReference SubdistrictName
		{
			get
			{
				if (_subdistrictName == null)
				{
					_subdistrictName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "subdistrictName", cr2w, this);
				}
				return _subdistrictName;
			}
			set
			{
				if (_subdistrictName == value)
				{
					return;
				}
				_subdistrictName = value;
				PropertySet(this);
			}
		}

		public inkStreetNameSignLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
