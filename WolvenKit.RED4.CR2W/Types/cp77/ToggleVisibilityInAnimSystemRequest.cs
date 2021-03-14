using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleVisibilityInAnimSystemRequest : gameScriptableSystemRequest
	{
		private entEntityID _entityID;
		private CBool _isVisible;
		private CName _sourceName;
		private CFloat _transitionTime;
		private CBool _forcedVisibleOnlyInFrustum;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CBool) CR2WTypeManager.Create("Bool", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get
			{
				if (_sourceName == null)
				{
					_sourceName = (CName) CR2WTypeManager.Create("CName", "sourceName", cr2w, this);
				}
				return _sourceName;
			}
			set
			{
				if (_sourceName == value)
				{
					return;
				}
				_sourceName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("transitionTime")] 
		public CFloat TransitionTime
		{
			get
			{
				if (_transitionTime == null)
				{
					_transitionTime = (CFloat) CR2WTypeManager.Create("Float", "transitionTime", cr2w, this);
				}
				return _transitionTime;
			}
			set
			{
				if (_transitionTime == value)
				{
					return;
				}
				_transitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forcedVisibleOnlyInFrustum")] 
		public CBool ForcedVisibleOnlyInFrustum
		{
			get
			{
				if (_forcedVisibleOnlyInFrustum == null)
				{
					_forcedVisibleOnlyInFrustum = (CBool) CR2WTypeManager.Create("Bool", "forcedVisibleOnlyInFrustum", cr2w, this);
				}
				return _forcedVisibleOnlyInFrustum;
			}
			set
			{
				if (_forcedVisibleOnlyInFrustum == value)
				{
					return;
				}
				_forcedVisibleOnlyInFrustum = value;
				PropertySet(this);
			}
		}

		public ToggleVisibilityInAnimSystemRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
