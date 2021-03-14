using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RevealInteractionWheel : redEvent
	{
		private wCHandle<gameObject> _lookAtObject;
		private CArray<CHandle<QuickhackData>> _commands;
		private CBool _shouldReveal;

		[Ordinal(0)] 
		[RED("lookAtObject")] 
		public wCHandle<gameObject> LookAtObject
		{
			get
			{
				if (_lookAtObject == null)
				{
					_lookAtObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lookAtObject", cr2w, this);
				}
				return _lookAtObject;
			}
			set
			{
				if (_lookAtObject == value)
				{
					return;
				}
				_lookAtObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("commands")] 
		public CArray<CHandle<QuickhackData>> Commands
		{
			get
			{
				if (_commands == null)
				{
					_commands = (CArray<CHandle<QuickhackData>>) CR2WTypeManager.Create("array:handle:QuickhackData", "commands", cr2w, this);
				}
				return _commands;
			}
			set
			{
				if (_commands == value)
				{
					return;
				}
				_commands = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get
			{
				if (_shouldReveal == null)
				{
					_shouldReveal = (CBool) CR2WTypeManager.Create("Bool", "shouldReveal", cr2w, this);
				}
				return _shouldReveal;
			}
			set
			{
				if (_shouldReveal == value)
				{
					return;
				}
				_shouldReveal = value;
				PropertySet(this);
			}
		}

		public RevealInteractionWheel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
