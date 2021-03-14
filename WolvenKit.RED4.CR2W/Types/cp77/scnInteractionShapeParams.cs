using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnInteractionShapeParams : ISerializable
	{
		private CEnum<scnChoiceNodeNsSizePreset> _preset;
		private Vector3 _offset;
		private Quaternion _rotation;
		private CFloat _customIndicationRange;
		private CFloat _customActivationRange;
		private CFloat _activationYawLimit;
		private CFloat _activationBaseLength;
		private CFloat _activationHeight;

		[Ordinal(0)] 
		[RED("preset")] 
		public CEnum<scnChoiceNodeNsSizePreset> Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (CEnum<scnChoiceNodeNsSizePreset>) CR2WTypeManager.Create("scnChoiceNodeNsSizePreset", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Vector3) CR2WTypeManager.Create("Vector3", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("rotation")] 
		public Quaternion Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (Quaternion) CR2WTypeManager.Create("Quaternion", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("customIndicationRange")] 
		public CFloat CustomIndicationRange
		{
			get
			{
				if (_customIndicationRange == null)
				{
					_customIndicationRange = (CFloat) CR2WTypeManager.Create("Float", "customIndicationRange", cr2w, this);
				}
				return _customIndicationRange;
			}
			set
			{
				if (_customIndicationRange == value)
				{
					return;
				}
				_customIndicationRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("customActivationRange")] 
		public CFloat CustomActivationRange
		{
			get
			{
				if (_customActivationRange == null)
				{
					_customActivationRange = (CFloat) CR2WTypeManager.Create("Float", "customActivationRange", cr2w, this);
				}
				return _customActivationRange;
			}
			set
			{
				if (_customActivationRange == value)
				{
					return;
				}
				_customActivationRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("activationYawLimit")] 
		public CFloat ActivationYawLimit
		{
			get
			{
				if (_activationYawLimit == null)
				{
					_activationYawLimit = (CFloat) CR2WTypeManager.Create("Float", "activationYawLimit", cr2w, this);
				}
				return _activationYawLimit;
			}
			set
			{
				if (_activationYawLimit == value)
				{
					return;
				}
				_activationYawLimit = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("activationBaseLength")] 
		public CFloat ActivationBaseLength
		{
			get
			{
				if (_activationBaseLength == null)
				{
					_activationBaseLength = (CFloat) CR2WTypeManager.Create("Float", "activationBaseLength", cr2w, this);
				}
				return _activationBaseLength;
			}
			set
			{
				if (_activationBaseLength == value)
				{
					return;
				}
				_activationBaseLength = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("activationHeight")] 
		public CFloat ActivationHeight
		{
			get
			{
				if (_activationHeight == null)
				{
					_activationHeight = (CFloat) CR2WTypeManager.Create("Float", "activationHeight", cr2w, this);
				}
				return _activationHeight;
			}
			set
			{
				if (_activationHeight == value)
				{
					return;
				}
				_activationHeight = value;
				PropertySet(this);
			}
		}

		public scnInteractionShapeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
