using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoverObject : gameObject
	{
		private CEnum<animCoverState> _coverType;
		private CFloat _slotRadius;
		private CFloat _hpMax;
		private CBool _isDestructible;
		private CFloat _fovDegrees;
		private CFloat _fovExposureDegrees;

		[Ordinal(40)] 
		[RED("coverType")] 
		public CEnum<animCoverState> CoverType
		{
			get
			{
				if (_coverType == null)
				{
					_coverType = (CEnum<animCoverState>) CR2WTypeManager.Create("animCoverState", "coverType", cr2w, this);
				}
				return _coverType;
			}
			set
			{
				if (_coverType == value)
				{
					return;
				}
				_coverType = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("slotRadius")] 
		public CFloat SlotRadius
		{
			get
			{
				if (_slotRadius == null)
				{
					_slotRadius = (CFloat) CR2WTypeManager.Create("Float", "slotRadius", cr2w, this);
				}
				return _slotRadius;
			}
			set
			{
				if (_slotRadius == value)
				{
					return;
				}
				_slotRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("hpMax")] 
		public CFloat HpMax
		{
			get
			{
				if (_hpMax == null)
				{
					_hpMax = (CFloat) CR2WTypeManager.Create("Float", "hpMax", cr2w, this);
				}
				return _hpMax;
			}
			set
			{
				if (_hpMax == value)
				{
					return;
				}
				_hpMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get
			{
				if (_isDestructible == null)
				{
					_isDestructible = (CBool) CR2WTypeManager.Create("Bool", "isDestructible", cr2w, this);
				}
				return _isDestructible;
			}
			set
			{
				if (_isDestructible == value)
				{
					return;
				}
				_isDestructible = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("fovDegrees")] 
		public CFloat FovDegrees
		{
			get
			{
				if (_fovDegrees == null)
				{
					_fovDegrees = (CFloat) CR2WTypeManager.Create("Float", "fovDegrees", cr2w, this);
				}
				return _fovDegrees;
			}
			set
			{
				if (_fovDegrees == value)
				{
					return;
				}
				_fovDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("fovExposureDegrees")] 
		public CFloat FovExposureDegrees
		{
			get
			{
				if (_fovExposureDegrees == null)
				{
					_fovExposureDegrees = (CFloat) CR2WTypeManager.Create("Float", "fovExposureDegrees", cr2w, this);
				}
				return _fovExposureDegrees;
			}
			set
			{
				if (_fovExposureDegrees == value)
				{
					return;
				}
				_fovExposureDegrees = value;
				PropertySet(this);
			}
		}

		public gameCoverObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
