using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RequestDismembermentEvent : AIAIEvent
	{
		private CEnum<gameDismBodyPart> _bodyPart;
		private CEnum<gameDismWoundType> _dismembermentType;
		private Vector4 _hitPosition;
		private CBool _isCritical;

		[Ordinal(2)] 
		[RED("bodyPart")] 
		public CEnum<gameDismBodyPart> BodyPart
		{
			get
			{
				if (_bodyPart == null)
				{
					_bodyPart = (CEnum<gameDismBodyPart>) CR2WTypeManager.Create("gameDismBodyPart", "bodyPart", cr2w, this);
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

		[Ordinal(3)] 
		[RED("dismembermentType")] 
		public CEnum<gameDismWoundType> DismembermentType
		{
			get
			{
				if (_dismembermentType == null)
				{
					_dismembermentType = (CEnum<gameDismWoundType>) CR2WTypeManager.Create("gameDismWoundType", "dismembermentType", cr2w, this);
				}
				return _dismembermentType;
			}
			set
			{
				if (_dismembermentType == value)
				{
					return;
				}
				_dismembermentType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		public RequestDismembermentEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
