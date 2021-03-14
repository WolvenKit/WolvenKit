using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToWorld : scnSceneEvent
	{
		private scnPropId _propId;
		private CEnum<scnOffsetMode> _offsetMode;
		private Vector3 _customOffsetPos;
		private Quaternion _customOffsetRot;
		private scnPerformerId _referencePerformer;
		private TweakDBID _referencePerformerSlotId;
		private TweakDBID _referencePerformerItemId;
		private CStatic<scneventsAttachPropToWorldCachedFallbackBone> _fallbackCachedBones;
		private rRef<animAnimSet> _fallbackAnimset;
		private CName _fallbackAnimationName;
		private CFloat _fallbackAnimTime;

		[Ordinal(6)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("offsetMode")] 
		public CEnum<scnOffsetMode> OffsetMode
		{
			get
			{
				if (_offsetMode == null)
				{
					_offsetMode = (CEnum<scnOffsetMode>) CR2WTypeManager.Create("scnOffsetMode", "offsetMode", cr2w, this);
				}
				return _offsetMode;
			}
			set
			{
				if (_offsetMode == value)
				{
					return;
				}
				_offsetMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("customOffsetPos")] 
		public Vector3 CustomOffsetPos
		{
			get
			{
				if (_customOffsetPos == null)
				{
					_customOffsetPos = (Vector3) CR2WTypeManager.Create("Vector3", "customOffsetPos", cr2w, this);
				}
				return _customOffsetPos;
			}
			set
			{
				if (_customOffsetPos == value)
				{
					return;
				}
				_customOffsetPos = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("customOffsetRot")] 
		public Quaternion CustomOffsetRot
		{
			get
			{
				if (_customOffsetRot == null)
				{
					_customOffsetRot = (Quaternion) CR2WTypeManager.Create("Quaternion", "customOffsetRot", cr2w, this);
				}
				return _customOffsetRot;
			}
			set
			{
				if (_customOffsetRot == value)
				{
					return;
				}
				_customOffsetRot = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("referencePerformer")] 
		public scnPerformerId ReferencePerformer
		{
			get
			{
				if (_referencePerformer == null)
				{
					_referencePerformer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "referencePerformer", cr2w, this);
				}
				return _referencePerformer;
			}
			set
			{
				if (_referencePerformer == value)
				{
					return;
				}
				_referencePerformer = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("referencePerformerSlotId")] 
		public TweakDBID ReferencePerformerSlotId
		{
			get
			{
				if (_referencePerformerSlotId == null)
				{
					_referencePerformerSlotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "referencePerformerSlotId", cr2w, this);
				}
				return _referencePerformerSlotId;
			}
			set
			{
				if (_referencePerformerSlotId == value)
				{
					return;
				}
				_referencePerformerSlotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("referencePerformerItemId")] 
		public TweakDBID ReferencePerformerItemId
		{
			get
			{
				if (_referencePerformerItemId == null)
				{
					_referencePerformerItemId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "referencePerformerItemId", cr2w, this);
				}
				return _referencePerformerItemId;
			}
			set
			{
				if (_referencePerformerItemId == value)
				{
					return;
				}
				_referencePerformerItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones
		{
			get
			{
				if (_fallbackCachedBones == null)
				{
					_fallbackCachedBones = (CStatic<scneventsAttachPropToWorldCachedFallbackBone>) CR2WTypeManager.Create("static:2,scneventsAttachPropToWorldCachedFallbackBone", "fallbackCachedBones", cr2w, this);
				}
				return _fallbackCachedBones;
			}
			set
			{
				if (_fallbackCachedBones == value)
				{
					return;
				}
				_fallbackCachedBones = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fallbackAnimset")] 
		public rRef<animAnimSet> FallbackAnimset
		{
			get
			{
				if (_fallbackAnimset == null)
				{
					_fallbackAnimset = (rRef<animAnimSet>) CR2WTypeManager.Create("rRef:animAnimSet", "fallbackAnimset", cr2w, this);
				}
				return _fallbackAnimset;
			}
			set
			{
				if (_fallbackAnimset == value)
				{
					return;
				}
				_fallbackAnimset = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get
			{
				if (_fallbackAnimationName == null)
				{
					_fallbackAnimationName = (CName) CR2WTypeManager.Create("CName", "fallbackAnimationName", cr2w, this);
				}
				return _fallbackAnimationName;
			}
			set
			{
				if (_fallbackAnimationName == value)
				{
					return;
				}
				_fallbackAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get
			{
				if (_fallbackAnimTime == null)
				{
					_fallbackAnimTime = (CFloat) CR2WTypeManager.Create("Float", "fallbackAnimTime", cr2w, this);
				}
				return _fallbackAnimTime;
			}
			set
			{
				if (_fallbackAnimTime == value)
				{
					return;
				}
				_fallbackAnimTime = value;
				PropertySet(this);
			}
		}

		public scneventsAttachPropToWorld(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
