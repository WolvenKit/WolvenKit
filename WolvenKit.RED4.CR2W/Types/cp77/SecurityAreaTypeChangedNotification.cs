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
			get => GetProperty(ref _previousType);
			set => SetProperty(ref _previousType, value);
		}

		[Ordinal(1)] 
		[RED("currentType")] 
		public CEnum<ESecurityAreaType> CurrentType
		{
			get => GetProperty(ref _currentType);
			set => SetProperty(ref _currentType, value);
		}

		[Ordinal(2)] 
		[RED("area")] 
		public wCHandle<SecurityAreaControllerPS> Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		public SecurityAreaTypeChangedNotification(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
