using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsclothPhaseConfig : CVariable
	{
		private CFloat _stiffness;
		private CFloat _stiffnessMultiplier;
		private CFloat _compressionLimit;
		private CFloat _stretchLimit;

		[Ordinal(0)] 
		[RED("stiffness")] 
		public CFloat Stiffness
		{
			get
			{
				if (_stiffness == null)
				{
					_stiffness = (CFloat) CR2WTypeManager.Create("Float", "stiffness", cr2w, this);
				}
				return _stiffness;
			}
			set
			{
				if (_stiffness == value)
				{
					return;
				}
				_stiffness = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stiffnessMultiplier")] 
		public CFloat StiffnessMultiplier
		{
			get
			{
				if (_stiffnessMultiplier == null)
				{
					_stiffnessMultiplier = (CFloat) CR2WTypeManager.Create("Float", "stiffnessMultiplier", cr2w, this);
				}
				return _stiffnessMultiplier;
			}
			set
			{
				if (_stiffnessMultiplier == value)
				{
					return;
				}
				_stiffnessMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compressionLimit")] 
		public CFloat CompressionLimit
		{
			get
			{
				if (_compressionLimit == null)
				{
					_compressionLimit = (CFloat) CR2WTypeManager.Create("Float", "compressionLimit", cr2w, this);
				}
				return _compressionLimit;
			}
			set
			{
				if (_compressionLimit == value)
				{
					return;
				}
				_compressionLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stretchLimit")] 
		public CFloat StretchLimit
		{
			get
			{
				if (_stretchLimit == null)
				{
					_stretchLimit = (CFloat) CR2WTypeManager.Create("Float", "stretchLimit", cr2w, this);
				}
				return _stretchLimit;
			}
			set
			{
				if (_stretchLimit == value)
				{
					return;
				}
				_stretchLimit = value;
				PropertySet(this);
			}
		}

		public physicsclothPhaseConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
