using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsSpawnEntityEventParams : CVariable
	{
		private scnPerformerId _performer;
		private scnPerformerId _referencePerformer;
		private TweakDBID _referencePerformerSlotId;
		private TweakDBID _referencePerformerItemId;
		private CStatic<scneventsSpawnEntityEventCachedFallbackBone> _fallbackCachedBones;
		private rRef<animAnimSet> _fallbackAnimset;
		private CName _fallbackAnimationName;
		private CFloat _fallbackAnimTime;

		[Ordinal(0)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get
			{
				if (_performer == null)
				{
					_performer = (scnPerformerId) CR2WTypeManager.Create("scnPerformerId", "performer", cr2w, this);
				}
				return _performer;
			}
			set
			{
				if (_performer == value)
				{
					return;
				}
				_performer = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsSpawnEntityEventCachedFallbackBone> FallbackCachedBones
		{
			get
			{
				if (_fallbackCachedBones == null)
				{
					_fallbackCachedBones = (CStatic<scneventsSpawnEntityEventCachedFallbackBone>) CR2WTypeManager.Create("static:2,scneventsSpawnEntityEventCachedFallbackBone", "fallbackCachedBones", cr2w, this);
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		public scneventsSpawnEntityEventParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
