using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCoverDefinition : gameSmartObjectWorkspotDefinition
	{
		private CFloat _overridenCoveringFOVDegrees;
		private CFloat _overridenCoveringVerticalFOVDegrees;
		private CFloat _fovExposureDegrees;
		private CEnum<gameCoverHeight> _overridenHeight;
		private CBool _overrideGeneratedCoverAngles;

		[Ordinal(6)] 
		[RED("overridenCoveringFOVDegrees")] 
		public CFloat OverridenCoveringFOVDegrees
		{
			get
			{
				if (_overridenCoveringFOVDegrees == null)
				{
					_overridenCoveringFOVDegrees = (CFloat) CR2WTypeManager.Create("Float", "overridenCoveringFOVDegrees", cr2w, this);
				}
				return _overridenCoveringFOVDegrees;
			}
			set
			{
				if (_overridenCoveringFOVDegrees == value)
				{
					return;
				}
				_overridenCoveringFOVDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("overridenCoveringVerticalFOVDegrees")] 
		public CFloat OverridenCoveringVerticalFOVDegrees
		{
			get
			{
				if (_overridenCoveringVerticalFOVDegrees == null)
				{
					_overridenCoveringVerticalFOVDegrees = (CFloat) CR2WTypeManager.Create("Float", "overridenCoveringVerticalFOVDegrees", cr2w, this);
				}
				return _overridenCoveringVerticalFOVDegrees;
			}
			set
			{
				if (_overridenCoveringVerticalFOVDegrees == value)
				{
					return;
				}
				_overridenCoveringVerticalFOVDegrees = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("overridenHeight")] 
		public CEnum<gameCoverHeight> OverridenHeight
		{
			get
			{
				if (_overridenHeight == null)
				{
					_overridenHeight = (CEnum<gameCoverHeight>) CR2WTypeManager.Create("gameCoverHeight", "overridenHeight", cr2w, this);
				}
				return _overridenHeight;
			}
			set
			{
				if (_overridenHeight == value)
				{
					return;
				}
				_overridenHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("overrideGeneratedCoverAngles")] 
		public CBool OverrideGeneratedCoverAngles
		{
			get
			{
				if (_overrideGeneratedCoverAngles == null)
				{
					_overrideGeneratedCoverAngles = (CBool) CR2WTypeManager.Create("Bool", "overrideGeneratedCoverAngles", cr2w, this);
				}
				return _overrideGeneratedCoverAngles;
			}
			set
			{
				if (_overrideGeneratedCoverAngles == value)
				{
					return;
				}
				_overrideGeneratedCoverAngles = value;
				PropertySet(this);
			}
		}

		public gameCoverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
