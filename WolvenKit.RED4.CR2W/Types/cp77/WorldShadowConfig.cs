using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldShadowConfig : CVariable
	{
		private ContactShadowsConfig _contactShadows;
		private CUInt32 _distantShadowsNumLevels;
		private CFloat _distantShadowsBaseLevelRadius;
		private FoliageShadowConfig _foliageShadowConfig;

		[Ordinal(0)] 
		[RED("contactShadows")] 
		public ContactShadowsConfig ContactShadows
		{
			get
			{
				if (_contactShadows == null)
				{
					_contactShadows = (ContactShadowsConfig) CR2WTypeManager.Create("ContactShadowsConfig", "contactShadows", cr2w, this);
				}
				return _contactShadows;
			}
			set
			{
				if (_contactShadows == value)
				{
					return;
				}
				_contactShadows = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("distantShadowsNumLevels")] 
		public CUInt32 DistantShadowsNumLevels
		{
			get
			{
				if (_distantShadowsNumLevels == null)
				{
					_distantShadowsNumLevels = (CUInt32) CR2WTypeManager.Create("Uint32", "distantShadowsNumLevels", cr2w, this);
				}
				return _distantShadowsNumLevels;
			}
			set
			{
				if (_distantShadowsNumLevels == value)
				{
					return;
				}
				_distantShadowsNumLevels = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("distantShadowsBaseLevelRadius")] 
		public CFloat DistantShadowsBaseLevelRadius
		{
			get
			{
				if (_distantShadowsBaseLevelRadius == null)
				{
					_distantShadowsBaseLevelRadius = (CFloat) CR2WTypeManager.Create("Float", "distantShadowsBaseLevelRadius", cr2w, this);
				}
				return _distantShadowsBaseLevelRadius;
			}
			set
			{
				if (_distantShadowsBaseLevelRadius == value)
				{
					return;
				}
				_distantShadowsBaseLevelRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("foliageShadowConfig")] 
		public FoliageShadowConfig FoliageShadowConfig
		{
			get
			{
				if (_foliageShadowConfig == null)
				{
					_foliageShadowConfig = (FoliageShadowConfig) CR2WTypeManager.Create("FoliageShadowConfig", "foliageShadowConfig", cr2w, this);
				}
				return _foliageShadowConfig;
			}
			set
			{
				if (_foliageShadowConfig == value)
				{
					return;
				}
				_foliageShadowConfig = value;
				PropertySet(this);
			}
		}

		public WorldShadowConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
