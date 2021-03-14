using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismemberEffector : gameEffector
	{
		private CName _bodyPart;
		private CName _woundType;
		private Vector3 _hitPosition;
		private CBool _isCritical;

		[Ordinal(0)] 
		[RED("bodyPart")] 
		public CName BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CName) CR2WTypeManager.Create("CName", "bodyPart", cr2w, this);
				}
				return _bodyPart;
			}
			set
			{
				if (_bodyPart == value)
				{
					return;
				}
				_bodyPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("woundType")] 
		public CName WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CName) CR2WTypeManager.Create("CName", "woundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitPosition")] 
		public Vector3 HitPosition
		{
			get
			{
				if (_hitPosition == null)
				{
					_hitPosition = (Vector3) CR2WTypeManager.Create("Vector3", "hitPosition", cr2w, this);
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

		[Ordinal(3)] 
		[RED("isCritical")] 
		public CBool IsCritical
		{
			get
			{
				if (_isCritical == null)
				{
					_isCritical = (CBool) CR2WTypeManager.Create("Bool", "isCritical", cr2w, this);
				}
				return _isCritical;
			}
			set
			{
				if (_isCritical == value)
				{
					return;
				}
				_isCritical = value;
				PropertySet(this);
			}
		}

		public DismemberEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
