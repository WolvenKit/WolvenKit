using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UseWorkspotCommandHandler : AICommandHandlerBase
	{
		private CHandle<AIArgumentMapping> _outMoveToWorkspot;
		private CHandle<AIArgumentMapping> _outForceEntryAnimName;
		private CHandle<AIArgumentMapping> _outContinueInCombat;

		[Ordinal(1)] 
		[RED("outMoveToWorkspot")] 
		public CHandle<AIArgumentMapping> OutMoveToWorkspot
		{
			get
			{
				if (_outMoveToWorkspot == null)
				{
					_outMoveToWorkspot = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outMoveToWorkspot", cr2w, this);
				}
				return _outMoveToWorkspot;
			}
			set
			{
				if (_outMoveToWorkspot == value)
				{
					return;
				}
				_outMoveToWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outForceEntryAnimName")] 
		public CHandle<AIArgumentMapping> OutForceEntryAnimName
		{
			get
			{
				if (_outForceEntryAnimName == null)
				{
					_outForceEntryAnimName = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outForceEntryAnimName", cr2w, this);
				}
				return _outForceEntryAnimName;
			}
			set
			{
				if (_outForceEntryAnimName == value)
				{
					return;
				}
				_outForceEntryAnimName = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("outContinueInCombat")] 
		public CHandle<AIArgumentMapping> OutContinueInCombat
		{
			get
			{
				if (_outContinueInCombat == null)
				{
					_outContinueInCombat = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "outContinueInCombat", cr2w, this);
				}
				return _outContinueInCombat;
			}
			set
			{
				if (_outContinueInCombat == value)
				{
					return;
				}
				_outContinueInCombat = value;
				PropertySet(this);
			}
		}

		public UseWorkspotCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
