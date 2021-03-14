using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaTypeChangedNotification : redEvent
	{
		private CEnum<ESecurityAreaType> _previousType;
		private CEnum<ESecurityAreaType> _currentType;
		private wCHandle<SecurityAreaControllerPS> _area;

		[Ordinal(0)] 
		[RED("previousType")] 
		public CEnum<ESecurityAreaType> PreviousType
		{
			get
			{
				if (_previousType == null)
				{
					_previousType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "previousType", cr2w, this);
				}
				return _previousType;
			}
			set
			{
				if (_previousType == value)
				{
					return;
				}
				_previousType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentType")] 
		public CEnum<ESecurityAreaType> CurrentType
		{
			get
			{
				if (_currentType == null)
				{
					_currentType = (CEnum<ESecurityAreaType>) CR2WTypeManager.Create("ESecurityAreaType", "currentType", cr2w, this);
				}
				return _currentType;
			}
			set
			{
				if (_currentType == value)
				{
					return;
				}
				_currentType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("area")] 
		public wCHandle<SecurityAreaControllerPS> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (wCHandle<SecurityAreaControllerPS>) CR2WTypeManager.Create("whandle:SecurityAreaControllerPS", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		public SecurityAreaTypeChangedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
