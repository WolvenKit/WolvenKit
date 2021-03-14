using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersData : CVariable
	{
		private CEnum<EWindowBlindersStates> _windowBlindersState;
		private CBool _hasOpenInteraction;
		private CBool _hasTiltInteraction;
		private CBool _hasQuickHack;

		[Ordinal(0)] 
		[RED("windowBlindersState")] 
		public CEnum<EWindowBlindersStates> WindowBlindersState
		{
			get
			{
				if (_windowBlindersState == null)
				{
					_windowBlindersState = (CEnum<EWindowBlindersStates>) CR2WTypeManager.Create("EWindowBlindersStates", "windowBlindersState", cr2w, this);
				}
				return _windowBlindersState;
			}
			set
			{
				if (_windowBlindersState == value)
				{
					return;
				}
				_windowBlindersState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("hasOpenInteraction")] 
		public CBool HasOpenInteraction
		{
			get
			{
				if (_hasOpenInteraction == null)
				{
					_hasOpenInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasOpenInteraction", cr2w, this);
				}
				return _hasOpenInteraction;
			}
			set
			{
				if (_hasOpenInteraction == value)
				{
					return;
				}
				_hasOpenInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("hasTiltInteraction")] 
		public CBool HasTiltInteraction
		{
			get
			{
				if (_hasTiltInteraction == null)
				{
					_hasTiltInteraction = (CBool) CR2WTypeManager.Create("Bool", "hasTiltInteraction", cr2w, this);
				}
				return _hasTiltInteraction;
			}
			set
			{
				if (_hasTiltInteraction == value)
				{
					return;
				}
				_hasTiltInteraction = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("hasQuickHack")] 
		public CBool HasQuickHack
		{
			get
			{
				if (_hasQuickHack == null)
				{
					_hasQuickHack = (CBool) CR2WTypeManager.Create("Bool", "hasQuickHack", cr2w, this);
				}
				return _hasQuickHack;
			}
			set
			{
				if (_hasQuickHack == value)
				{
					return;
				}
				_hasQuickHack = value;
				PropertySet(this);
			}
		}

		public WindowBlindersData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
