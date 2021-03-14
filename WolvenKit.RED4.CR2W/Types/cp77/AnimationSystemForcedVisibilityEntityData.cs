using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimationSystemForcedVisibilityEntityData : IScriptable
	{
		private wCHandle<AnimationSystemForcedVisibilityManager> _owner;
		private entEntityID _entityID;
		private CArray<CHandle<ForcedVisibilityInAnimSystemData>> _forcedVisibilityInAnimSystemRequests;
		private CArray<CHandle<ForcedVisibilityInAnimSystemData>> _delayedForcedVisibilityInAnimSystemRequests;
		private CBool _hasVisibilityForcedInAnimSystem;
		private CBool _hasVisibilityForcedOnlyInFrustumInAnimSystem;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<AnimationSystemForcedVisibilityManager> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<AnimationSystemForcedVisibilityManager>) CR2WTypeManager.Create("whandle:AnimationSystemForcedVisibilityManager", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> ForcedVisibilityInAnimSystemRequests
		{
			get
			{
				if (_forcedVisibilityInAnimSystemRequests == null)
				{
					_forcedVisibilityInAnimSystemRequests = (CArray<CHandle<ForcedVisibilityInAnimSystemData>>) CR2WTypeManager.Create("array:handle:ForcedVisibilityInAnimSystemData", "forcedVisibilityInAnimSystemRequests", cr2w, this);
				}
				return _forcedVisibilityInAnimSystemRequests;
			}
			set
			{
				if (_forcedVisibilityInAnimSystemRequests == value)
				{
					return;
				}
				_forcedVisibilityInAnimSystemRequests = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("delayedForcedVisibilityInAnimSystemRequests")] 
		public CArray<CHandle<ForcedVisibilityInAnimSystemData>> DelayedForcedVisibilityInAnimSystemRequests
		{
			get
			{
				if (_delayedForcedVisibilityInAnimSystemRequests == null)
				{
					_delayedForcedVisibilityInAnimSystemRequests = (CArray<CHandle<ForcedVisibilityInAnimSystemData>>) CR2WTypeManager.Create("array:handle:ForcedVisibilityInAnimSystemData", "delayedForcedVisibilityInAnimSystemRequests", cr2w, this);
				}
				return _delayedForcedVisibilityInAnimSystemRequests;
			}
			set
			{
				if (_delayedForcedVisibilityInAnimSystemRequests == value)
				{
					return;
				}
				_delayedForcedVisibilityInAnimSystemRequests = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get
			{
				if (_hasVisibilityForcedInAnimSystem == null)
				{
					_hasVisibilityForcedInAnimSystem = (CBool) CR2WTypeManager.Create("Bool", "hasVisibilityForcedInAnimSystem", cr2w, this);
				}
				return _hasVisibilityForcedInAnimSystem;
			}
			set
			{
				if (_hasVisibilityForcedInAnimSystem == value)
				{
					return;
				}
				_hasVisibilityForcedInAnimSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("hasVisibilityForcedOnlyInFrustumInAnimSystem")] 
		public CBool HasVisibilityForcedOnlyInFrustumInAnimSystem
		{
			get
			{
				if (_hasVisibilityForcedOnlyInFrustumInAnimSystem == null)
				{
					_hasVisibilityForcedOnlyInFrustumInAnimSystem = (CBool) CR2WTypeManager.Create("Bool", "hasVisibilityForcedOnlyInFrustumInAnimSystem", cr2w, this);
				}
				return _hasVisibilityForcedOnlyInFrustumInAnimSystem;
			}
			set
			{
				if (_hasVisibilityForcedOnlyInFrustumInAnimSystem == value)
				{
					return;
				}
				_hasVisibilityForcedOnlyInFrustumInAnimSystem = value;
				PropertySet(this);
			}
		}

		public AnimationSystemForcedVisibilityEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
