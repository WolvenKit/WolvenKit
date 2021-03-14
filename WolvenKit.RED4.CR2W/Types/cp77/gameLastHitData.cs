using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameLastHitData : CVariable
	{
		private entEntityID _targetEntityId;
		private CUInt32 _hitType;
		private CArray<CName> _hitShapes;

		[Ordinal(0)] 
		[RED("targetEntityId")] 
		public entEntityID TargetEntityId
		{
			get
			{
				if (_targetEntityId == null)
				{
					_targetEntityId = (entEntityID) CR2WTypeManager.Create("entEntityID", "targetEntityId", cr2w, this);
				}
				return _targetEntityId;
			}
			set
			{
				if (_targetEntityId == value)
				{
					return;
				}
				_targetEntityId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hitType")] 
		public CUInt32 HitType
		{
			get
			{
				if (_hitType == null)
				{
					_hitType = (CUInt32) CR2WTypeManager.Create("Uint32", "hitType", cr2w, this);
				}
				return _hitType;
			}
			set
			{
				if (_hitType == value)
				{
					return;
				}
				_hitType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hitShapes")] 
		public CArray<CName> HitShapes
		{
			get
			{
				if (_hitShapes == null)
				{
					_hitShapes = (CArray<CName>) CR2WTypeManager.Create("array:CName", "hitShapes", cr2w, this);
				}
				return _hitShapes;
			}
			set
			{
				if (_hitShapes == value)
				{
					return;
				}
				_hitShapes = value;
				PropertySet(this);
			}
		}

		public gameLastHitData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
