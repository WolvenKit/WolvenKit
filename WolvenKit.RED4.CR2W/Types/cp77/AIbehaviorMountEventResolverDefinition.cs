using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		private CHandle<AIArgumentMapping> _mountData;
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _isInstant;
		private CName _behaviorCallbackName;

		[Ordinal(0)] 
		[RED("mountData")] 
		public CHandle<AIArgumentMapping> MountData
		{
			get
			{
				if (_mountData == null)
				{
					_mountData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "mountData", cr2w, this);
				}
				return _mountData;
			}
			set
			{
				if (_mountData == value)
				{
					return;
				}
				_mountData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("isInstant")] 
		public CHandle<AIArgumentMapping> IsInstant
		{
			get
			{
				if (_isInstant == null)
				{
					_isInstant = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "isInstant", cr2w, this);
				}
				return _isInstant;
			}
			set
			{
				if (_isInstant == value)
				{
					return;
				}
				_isInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("behaviorCallbackName")] 
		public CName BehaviorCallbackName
		{
			get
			{
				if (_behaviorCallbackName == null)
				{
					_behaviorCallbackName = (CName) CR2WTypeManager.Create("CName", "behaviorCallbackName", cr2w, this);
				}
				return _behaviorCallbackName;
			}
			set
			{
				if (_behaviorCallbackName == value)
				{
					return;
				}
				_behaviorCallbackName = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMountEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
