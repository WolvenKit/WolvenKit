using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ToggleNetrunnerDive : ActionBool
	{
		private CBool _skipMinigame;
		private CInt32 _attempt;
		private CBool _isRemote;

		[Ordinal(25)] 
		[RED("skipMinigame")] 
		public CBool SkipMinigame
		{
			get
			{
				if (_skipMinigame == null)
				{
					_skipMinigame = (CBool) CR2WTypeManager.Create("Bool", "skipMinigame", cr2w, this);
				}
				return _skipMinigame;
			}
			set
			{
				if (_skipMinigame == value)
				{
					return;
				}
				_skipMinigame = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("attempt")] 
		public CInt32 Attempt
		{
			get
			{
				if (_attempt == null)
				{
					_attempt = (CInt32) CR2WTypeManager.Create("Int32", "attempt", cr2w, this);
				}
				return _attempt;
			}
			set
			{
				if (_attempt == value)
				{
					return;
				}
				_attempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("isRemote")] 
		public CBool IsRemote
		{
			get
			{
				if (_isRemote == null)
				{
					_isRemote = (CBool) CR2WTypeManager.Create("Bool", "isRemote", cr2w, this);
				}
				return _isRemote;
			}
			set
			{
				if (_isRemote == value)
				{
					return;
				}
				_isRemote = value;
				PropertySet(this);
			}
		}

		public ToggleNetrunnerDive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
