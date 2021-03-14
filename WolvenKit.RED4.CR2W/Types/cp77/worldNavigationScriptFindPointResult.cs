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
			get
			{
				if (_status == null)
				{
					_status = (CEnum<worldNavigationRequestStatus>) CR2WTypeManager.Create("worldNavigationRequestStatus", "status", cr2w, this);
				}
				return _status;
			}
			set
			{
				if (_status == value)
				{
					return;
				}
				_status = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("point")] 
		public Vector4 Point
		{
			get
			{
				if (_point == null)
				{
					_point = (Vector4) CR2WTypeManager.Create("Vector4", "point", cr2w, this);
				}
				return _point;
			}
			set
			{
				if (_point == value)
				{
					return;
				}
				_point = value;
				PropertySet(this);
			}
		}

		public worldNavigationScriptFindPointResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
