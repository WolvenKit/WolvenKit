using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDamageInfoUserData : IScriptable
	{
		private CArray<SHitFlag> _flags;
		private CEnum<EHitShapeType> _hitShapeType;

		[Ordinal(0)] 
		[RED("flags")] 
		public CArray<SHitFlag> Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CArray<SHitFlag>) CR2WTypeManager.Create("array:SHitFlag", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
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

		public gameuiDamageInfoUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
