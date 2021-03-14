using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectsCompiledResource : resStreamedResource
	{
		private CHandle<gameSmartObjectAnimationDatabase> _animationDatabase;
		private CHandle<gameCompiledNodes> _compiledNodesData;
		private CHandle<gameSmartObjectTransformDictionary> _transformDictionary;
		private CHandle<gameSmartObjectPropertyDictionary> _propertyDictionary;
		private CHandle<gameSmartObjectTransformSequenceDictionary> _transformSequenceDictionary;
		private CHandle<gameSmartObjectMembership> _soMembership;
		private Box _localBoundingBox;

		[Ordinal(1)] 
		[RED("animationDatabase")] 
		public CHandle<gameSmartObjectAnimationDatabase> AnimationDatabase
		{
			get
			{
				if (_animationDatabase == null)
				{
					_animationDatabase = (CHandle<gameSmartObjectAnimationDatabase>) CR2WTypeManager.Create("handle:gameSmartObjectAnimationDatabase", "animationDatabase", cr2w, this);
				}
				return _animationDatabase;
			}
			set
			{
				if (_animationDatabase == value)
				{
					return;
				}
				_animationDatabase = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("compiledNodesData")] 
		public CHandle<gameCompiledNodes> CompiledNodesData
		{
			get
			{
				if (_compiledNodesData == null)
				{
					_compiledNodesData = (CHandle<gameCompiledNodes>) CR2WTypeManager.Create("handle:gameCompiledNodes", "compiledNodesData", cr2w, this);
				}
				return _compiledNodesData;
			}
			set
			{
				if (_compiledNodesData == value)
				{
					return;
				}
				_compiledNodesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transformDictionary")] 
		public CHandle<gameSmartObjectTransformDictionary> TransformDictionary
		{
			get
			{
				if (_transformDictionary == null)
				{
					_transformDictionary = (CHandle<gameSmartObjectTransformDictionary>) CR2WTypeManager.Create("handle:gameSmartObjectTransformDictionary", "transformDictionary", cr2w, this);
				}
				return _transformDictionary;
			}
			set
			{
				if (_transformDictionary == value)
				{
					return;
				}
				_transformDictionary = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("propertyDictionary")] 
		public CHandle<gameSmartObjectPropertyDictionary> PropertyDictionary
		{
			get
			{
				if (_propertyDictionary == null)
				{
					_propertyDictionary = (CHandle<gameSmartObjectPropertyDictionary>) CR2WTypeManager.Create("handle:gameSmartObjectPropertyDictionary", "propertyDictionary", cr2w, this);
				}
				return _propertyDictionary;
			}
			set
			{
				if (_propertyDictionary == value)
				{
					return;
				}
				_propertyDictionary = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("transformSequenceDictionary")] 
		public CHandle<gameSmartObjectTransformSequenceDictionary> TransformSequenceDictionary
		{
			get
			{
				if (_transformSequenceDictionary == null)
				{
					_transformSequenceDictionary = (CHandle<gameSmartObjectTransformSequenceDictionary>) CR2WTypeManager.Create("handle:gameSmartObjectTransformSequenceDictionary", "transformSequenceDictionary", cr2w, this);
				}
				return _transformSequenceDictionary;
			}
			set
			{
				if (_transformSequenceDictionary == value)
				{
					return;
				}
				_transformSequenceDictionary = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("soMembership")] 
		public CHandle<gameSmartObjectMembership> SoMembership
		{
			get
			{
				if (_soMembership == null)
				{
					_soMembership = (CHandle<gameSmartObjectMembership>) CR2WTypeManager.Create("handle:gameSmartObjectMembership", "soMembership", cr2w, this);
				}
				return _soMembership;
			}
			set
			{
				if (_soMembership == value)
				{
					return;
				}
				_soMembership = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get
			{
				if (_localBoundingBox == null)
				{
					_localBoundingBox = (Box) CR2WTypeManager.Create("Box", "localBoundingBox", cr2w, this);
				}
				return _localBoundingBox;
			}
			set
			{
				if (_localBoundingBox == value)
				{
					return;
				}
				_localBoundingBox = value;
				PropertySet(this);
			}
		}

		public gameSmartObjectsCompiledResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
