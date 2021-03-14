using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIUseCoverCommand : AICombatRelatedCommand
	{
		private NodeRef _coverNodeRef;
		private CBool _oneTimeSelection;
		private CName _forcedEntryAnimation;
		private CArray<CEnum<AICoverExposureMethod>> _exposureMethods;
		private CHandle<CoverCommandParams> _limitToTheseExposureMethods;

		[Ordinal(5)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get
			{
				if (_coverNodeRef == null)
				{
					_coverNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "coverNodeRef", cr2w, this);
				}
				return _coverNodeRef;
			}
			set
			{
				if (_coverNodeRef == value)
				{
					return;
				}
				_coverNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("exposureMethods")] 
		public CArray<CEnum<AICoverExposureMethod>> ExposureMethods
		{
			get
			{
				if (_exposureMethods == null)
				{
					_exposureMethods = (CArray<CEnum<AICoverExposureMethod>>) CR2WTypeManager.Create("array:AICoverExposureMethod", "exposureMethods", cr2w, this);
				}
				return _exposureMethods;
			}
			set
			{
				if (_exposureMethods == value)
				{
					return;
				}
				_exposureMethods = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("limitToTheseExposureMethods")] 
		public CHandle<CoverCommandParams> LimitToTheseExposureMethods
		{
			get
			{
				if (_limitToTheseExposureMethods == null)
				{
					_limitToTheseExposureMethods = (CHandle<CoverCommandParams>) CR2WTypeManager.Create("handle:CoverCommandParams", "limitToTheseExposureMethods", cr2w, this);
				}
				return _limitToTheseExposureMethods;
			}
			set
			{
				if (_limitToTheseExposureMethods == value)
				{
					return;
				}
				_limitToTheseExposureMethods = value;
				PropertySet(this);
			}
		}

		public AIUseCoverCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
