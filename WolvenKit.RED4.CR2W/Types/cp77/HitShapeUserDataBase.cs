using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitShapeUserDataBase : gameHitShapeUserData
	{
		private CName _hitShapeTag;
		private CEnum<EHitShapeType> _hitShapeType;
		private CEnum<EHitReactionZone> _hitReactionZone;
		private CEnum<EAIDismembermentBodyPart> _dismembermentPart;
		private CBool _isProtectionLayer;
		private CBool _isInternalWeakspot;
		private CFloat _hitShapeDamageMod;

		[Ordinal(0)] 
		[RED("hitShapeTag")] 
		public CName HitShapeTag
		{
			get
			{
				if (_hitShapeTag == null)
				{
					_hitShapeTag = (CName) CR2WTypeManager.Create("CName", "hitShapeTag", cr2w, this);
				}
				return _hitShapeTag;
			}
			set
			{
				if (_hitShapeTag == value)
				{
					return;
				}
				_hitShapeTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitShapeType")] 
		public CEnum<EHitShapeType> HitShapeType
		{
			get
			{
				if (_hitShapeType == null)
				{
					_hitShapeType = (CEnum<EHitShapeType>) CR2WTypeManager.Create("EHitShapeType", "hitShapeType", cr2w, this);
				}
				return _hitShapeType;
			}
			set
			{
				if (_hitShapeType == value)
				{
					return;
				}
				_hitShapeType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitReactionZone")] 
		public CEnum<EHitReactionZone> HitReactionZone
		{
			get
			{
				if (_hitReactionZone == null)
				{
					_hitReactionZone = (CEnum<EHitReactionZone>) CR2WTypeManager.Create("EHitReactionZone", "hitReactionZone", cr2w, this);
				}
				return _hitReactionZone;
			}
			set
			{
				if (_hitReactionZone == value)
				{
					return;
				}
				_hitReactionZone = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("dismembermentPart")] 
		public CEnum<EAIDismembermentBodyPart> DismembermentPart
		{
			get
			{
				if (_dismembermentPart == null)
				{
					_dismembermentPart = (CEnum<EAIDismembermentBodyPart>) CR2WTypeManager.Create("EAIDismembermentBodyPart", "dismembermentPart", cr2w, this);
				}
				return _dismembermentPart;
			}
			set
			{
				if (_dismembermentPart == value)
				{
					return;
				}
				_dismembermentPart = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isProtectionLayer")] 
		public CBool IsProtectionLayer
		{
			get
			{
				if (_isProtectionLayer == null)
				{
					_isProtectionLayer = (CBool) CR2WTypeManager.Create("Bool", "isProtectionLayer", cr2w, this);
				}
				return _isProtectionLayer;
			}
			set
			{
				if (_isProtectionLayer == value)
				{
					return;
				}
				_isProtectionLayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("isInternalWeakspot")] 
		public CBool IsInternalWeakspot
		{
			get
			{
				if (_isInternalWeakspot == null)
				{
					_isInternalWeakspot = (CBool) CR2WTypeManager.Create("Bool", "isInternalWeakspot", cr2w, this);
				}
				return _isInternalWeakspot;
			}
			set
			{
				if (_isInternalWeakspot == value)
				{
					return;
				}
				_isInternalWeakspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("hitShapeDamageMod")] 
		public CFloat HitShapeDamageMod
		{
			get
			{
				if (_hitShapeDamageMod == null)
				{
					_hitShapeDamageMod = (CFloat) CR2WTypeManager.Create("Float", "hitShapeDamageMod", cr2w, this);
				}
				return _hitShapeDamageMod;
			}
			set
			{
				if (_hitShapeDamageMod == value)
				{
					return;
				}
				_hitShapeDamageMod = value;
				PropertySet(this);
			}
		}

		public HitShapeUserDataBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
