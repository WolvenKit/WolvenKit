using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OnDisableAreaData : CVariable
	{
		private gamePersistentID _agent;
		private CArray<CHandle<SecurityAreaControllerPS>> _remainingAreas;

		[Ordinal(0)] 
		[RED("agent")] 
		public gamePersistentID Agent
		{
			get
			{
				if (_agent == null)
				{
					_agent = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "agent", cr2w, this);
				}
				return _agent;
			}
			set
			{
				if (_agent == value)
				{
					return;
				}
				_agent = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("remainingAreas")] 
		public CArray<CHandle<SecurityAreaControllerPS>> RemainingAreas
		{
			get
			{
				if (_remainingAreas == null)
				{
					_remainingAreas = (CArray<CHandle<SecurityAreaControllerPS>>) CR2WTypeManager.Create("array:handle:SecurityAreaControllerPS", "remainingAreas", cr2w, this);
				}
				return _remainingAreas;
			}
			set
			{
				if (_remainingAreas == value)
				{
					return;
				}
				_remainingAreas = value;
				PropertySet(this);
			}
		}

		public OnDisableAreaData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
