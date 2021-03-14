using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCombatNodeParams_UseCover : questCombatNodeParams
	{
		private NodeRef _cover;
		private CBool _oneTimeSelection;
		private CArray<CEnum<AICoverExposureMethod>> _forceStance;
		private CName _forcedEntryAnimation;
		private CBool _immediately;

		[Ordinal(0)] 
		[RED("cover")] 
		public NodeRef Cover
		{
			get
			{
				if (_cover == null)
				{
					_cover = (NodeRef) CR2WTypeManager.Create("NodeRef", "cover", cr2w, this);
				}
				return _cover;
			}
			set
			{
				if (_cover == value)
				{
					return;
				}
				_cover = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("oneTimeSelection")] 
		public CBool OneTimeSelection
		{
			get
			{
				if (_oneTimeSelection == null)
				{
					_oneTimeSelection = (CBool) CR2WTypeManager.Create("Bool", "oneTimeSelection", cr2w, this);
				}
				return _oneTimeSelection;
			}
			set
			{
				if (_oneTimeSelection == value)
				{
					return;
				}
				_oneTimeSelection = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("forceStance")] 
		public CArray<CEnum<AICoverExposureMethod>> ForceStance
		{
			get
			{
				if (_forceStance == null)
				{
					_forceStance = (CArray<CEnum<AICoverExposureMethod>>) CR2WTypeManager.Create("array:AICoverExposureMethod", "forceStance", cr2w, this);
				}
				return _forceStance;
			}
			set
			{
				if (_forceStance == value)
				{
					return;
				}
				_forceStance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("forcedEntryAnimation")] 
		public CName ForcedEntryAnimation
		{
			get
			{
				if (_forcedEntryAnimation == null)
				{
					_forcedEntryAnimation = (CName) CR2WTypeManager.Create("CName", "forcedEntryAnimation", cr2w, this);
				}
				return _forcedEntryAnimation;
			}
			set
			{
				if (_forcedEntryAnimation == value)
				{
					return;
				}
				_forcedEntryAnimation = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("immediately")] 
		public CBool Immediately
		{
			get
			{
				if (_immediately == null)
				{
					_immediately = (CBool) CR2WTypeManager.Create("Bool", "immediately", cr2w, this);
				}
				return _immediately;
			}
			set
			{
				if (_immediately == value)
				{
					return;
				}
				_immediately = value;
				PropertySet(this);
			}
		}

		public questCombatNodeParams_UseCover(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
