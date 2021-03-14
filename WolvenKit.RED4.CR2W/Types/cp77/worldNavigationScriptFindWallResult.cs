using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptFindWallResult : IScriptable
	{
		private CEnum<worldNavigationRequestStatus> _status;
		private CBool _isHit;
		private Vector4 _hitPosition;

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
		[RED("isHit")] 
		public CBool IsHit
		{
			get
			{
				if (_isHit == null)
				{
					_isHit = (CBool) CR2WTypeManager.Create("Bool", "isHit", cr2w, this);
				}
				return _isHit;
			}
			set
			{
				if (_isHit == value)
				{
					return;
				}
				_isHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector4) CR2WTypeManager.Create("Vector4", "hitPosition", cr2w, this);
				}
				return _hitPosition;
			}
			set
			{
				if (_hitPosition == value)
				{
					return;
				}
				_hitPosition = value;
				PropertySet(this);
			}
		}

		public worldNavigationScriptFindWallResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
