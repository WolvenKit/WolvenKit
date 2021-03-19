using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptFindPointResult : CVariable
	{
		private CEnum<worldNavigationRequestStatus> _status;
		private Vector4 _point;

		[Ordinal(0)] 
		[RED("status")] 
		public CEnum<worldNavigationRequestStatus> Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetProperty(ref _point);
			set => SetProperty(ref _point, value);
		}

		public worldNavigationScriptFindPointResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
