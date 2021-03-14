using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitData_Base : gameHitShapeUserData
	{
		private CName _hitShapeTag;
		private CName _bodyPartStatPoolName;
		private CEnum<HitShape_Type> _hitShapeType;

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
		[RED("bodyPartStatPoolName")] 
		public CName BodyPartStatPoolName
		{
			get
			{
				if (_bodyPartStatPoolName == null)
				{
					_bodyPartStatPoolName = (CName) CR2WTypeManager.Create("CName", "bodyPartStatPoolName", cr2w, this);
				}
				return _bodyPartStatPoolName;
			}
			set
			{
				if (_bodyPartStatPoolName == value)
				{
					return;
				}
				_bodyPartStatPoolName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitShapeType")] 
		public CEnum<HitShape_Type> HitShapeType
		{
			get
			{
				if (_hitShapeType == null)
				{
					_hitShapeType = (CEnum<HitShape_Type>) CR2WTypeManager.Create("HitShape_Type", "hitShapeType", cr2w, this);
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

		public HitData_Base(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
