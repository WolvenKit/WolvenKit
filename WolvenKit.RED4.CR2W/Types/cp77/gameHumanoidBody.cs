using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameHumanoidBody : entIComponent
	{
		private CFloat _basePersonalSpace;
		private CFloat _baseHeight;
		private CFloat _baseEyesHeightRatio;
		private CName _stanceAnimFeatureName;
		private CName _aimAnimFeatureName;

		[Ordinal(3)] 
		[RED("basePersonalSpace")] 
		public CFloat BasePersonalSpace
		{
			get
			{
				if (_basePersonalSpace == null)
				{
					_basePersonalSpace = (CFloat) CR2WTypeManager.Create("Float", "basePersonalSpace", cr2w, this);
				}
				return _basePersonalSpace;
			}
			set
			{
				if (_basePersonalSpace == value)
				{
					return;
				}
				_basePersonalSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("baseHeight")] 
		public CFloat BaseHeight
		{
			get
			{
				if (_baseHeight == null)
				{
					_baseHeight = (CFloat) CR2WTypeManager.Create("Float", "baseHeight", cr2w, this);
				}
				return _baseHeight;
			}
			set
			{
				if (_baseHeight == value)
				{
					return;
				}
				_baseHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("baseEyesHeightRatio")] 
		public CFloat BaseEyesHeightRatio
		{
			get
			{
				if (_baseEyesHeightRatio == null)
				{
					_baseEyesHeightRatio = (CFloat) CR2WTypeManager.Create("Float", "baseEyesHeightRatio", cr2w, this);
				}
				return _baseEyesHeightRatio;
			}
			set
			{
				if (_baseEyesHeightRatio == value)
				{
					return;
				}
				_baseEyesHeightRatio = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("stanceAnimFeatureName")] 
		public CName StanceAnimFeatureName
		{
			get
			{
				if (_stanceAnimFeatureName == null)
				{
					_stanceAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "stanceAnimFeatureName", cr2w, this);
				}
				return _stanceAnimFeatureName;
			}
			set
			{
				if (_stanceAnimFeatureName == value)
				{
					return;
				}
				_stanceAnimFeatureName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("aimAnimFeatureName")] 
		public CName AimAnimFeatureName
		{
			get
			{
				if (_aimAnimFeatureName == null)
				{
					_aimAnimFeatureName = (CName) CR2WTypeManager.Create("CName", "aimAnimFeatureName", cr2w, this);
				}
				return _aimAnimFeatureName;
			}
			set
			{
				if (_aimAnimFeatureName == value)
				{
					return;
				}
				_aimAnimFeatureName = value;
				PropertySet(this);
			}
		}

		public gameHumanoidBody(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
