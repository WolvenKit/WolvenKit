using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entdismembermentEffectResource : ISerializable
	{
		private CName _name;
		private CArray<CName> _appearanceNames;
		private CEnum<physicsRagdollBodyPartE> _bodyPartMask;
		private Transform _offset;
		private CEnum<entdismembermentPlacementE> _placement;
		private CEnum<entdismembermentResourceSetMask> _resourceSets;
		private CEnum<entdismembermentWoundTypeE> _woundType;
		private raRef<worldEffect> _effect;
		private CBool _matchToWoundByName;

		[Ordinal(0)] 
		[RED("Name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "Name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("AppearanceNames")] 
		public CArray<CName> AppearanceNames
		{
			get
			{
				if (_appearanceNames == null)
				{
					_appearanceNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "AppearanceNames", cr2w, this);
				}
				return _appearanceNames;
			}
			set
			{
				if (_appearanceNames == value)
				{
					return;
				}
				_appearanceNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("BodyPartMask")] 
		public CEnum<physicsRagdollBodyPartE> BodyPartMask
		{
			get
			{
				if (_bodyPartMask == null)
				{
					_bodyPartMask = (CEnum<physicsRagdollBodyPartE>) CR2WTypeManager.Create("physicsRagdollBodyPartE", "BodyPartMask", cr2w, this);
				}
				return _bodyPartMask;
			}
			set
			{
				if (_bodyPartMask == value)
				{
					return;
				}
				_bodyPartMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Offset")] 
		public Transform Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (Transform) CR2WTypeManager.Create("Transform", "Offset", cr2w, this);
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

		[Ordinal(4)] 
		[RED("Placement")] 
		public CEnum<entdismembermentPlacementE> Placement
		{
			get
			{
				if (_placement == null)
				{
					_placement = (CEnum<entdismembermentPlacementE>) CR2WTypeManager.Create("entdismembermentPlacementE", "Placement", cr2w, this);
				}
				return _placement;
			}
			set
			{
				if (_placement == value)
				{
					return;
				}
				_placement = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ResourceSets")] 
		public CEnum<entdismembermentResourceSetMask> ResourceSets
		{
			get
			{
				if (_resourceSets == null)
				{
					_resourceSets = (CEnum<entdismembermentResourceSetMask>) CR2WTypeManager.Create("entdismembermentResourceSetMask", "ResourceSets", cr2w, this);
				}
				return _resourceSets;
			}
			set
			{
				if (_resourceSets == value)
				{
					return;
				}
				_resourceSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("WoundType")] 
		public CEnum<entdismembermentWoundTypeE> WoundType
		{
			get
			{
				if (_woundType == null)
				{
					_woundType = (CEnum<entdismembermentWoundTypeE>) CR2WTypeManager.Create("entdismembermentWoundTypeE", "WoundType", cr2w, this);
				}
				return _woundType;
			}
			set
			{
				if (_woundType == value)
				{
					return;
				}
				_woundType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("Effect")] 
		public raRef<worldEffect> Effect
		{
			get
			{
				if (_effect == null)
				{
					_effect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "Effect", cr2w, this);
				}
				return _effect;
			}
			set
			{
				if (_effect == value)
				{
					return;
				}
				_effect = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("MatchToWoundByName")] 
		public CBool MatchToWoundByName
		{
			get
			{
				if (_matchToWoundByName == null)
				{
					_matchToWoundByName = (CBool) CR2WTypeManager.Create("Bool", "MatchToWoundByName", cr2w, this);
				}
				return _matchToWoundByName;
			}
			set
			{
				if (_matchToWoundByName == value)
				{
					return;
				}
				_matchToWoundByName = value;
				PropertySet(this);
			}
		}

		public entdismembermentEffectResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
