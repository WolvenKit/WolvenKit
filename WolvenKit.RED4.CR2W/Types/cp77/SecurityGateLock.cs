using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLock : InteractiveDevice
	{
		private CHandle<gameStaticTriggerAreaComponent> _enteringArea;
		private CHandle<gameStaticTriggerAreaComponent> _centeredArea;
		private CHandle<gameStaticTriggerAreaComponent> _leavingArea;

		[Ordinal(93)] 
		[RED("enteringArea")] 
		public CHandle<gameStaticTriggerAreaComponent> EnteringArea
		{
			get
			{
				if (_enteringArea == null)
				{
					_enteringArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "enteringArea", cr2w, this);
				}
				return _enteringArea;
			}
			set
			{
				if (_enteringArea == value)
				{
					return;
				}
				_enteringArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("centeredArea")] 
		public CHandle<gameStaticTriggerAreaComponent> CenteredArea
		{
			get
			{
				if (_centeredArea == null)
				{
					_centeredArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "centeredArea", cr2w, this);
				}
				return _centeredArea;
			}
			set
			{
				if (_centeredArea == value)
				{
					return;
				}
				_centeredArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("leavingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> LeavingArea
		{
			get
			{
				if (_leavingArea == null)
				{
					_leavingArea = (CHandle<gameStaticTriggerAreaComponent>) CR2WTypeManager.Create("handle:gameStaticTriggerAreaComponent", "leavingArea", cr2w, this);
				}
				return _leavingArea;
			}
			set
			{
				if (_leavingArea == value)
				{
					return;
				}
				_leavingArea = value;
				PropertySet(this);
			}
		}

		public SecurityGateLock(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
