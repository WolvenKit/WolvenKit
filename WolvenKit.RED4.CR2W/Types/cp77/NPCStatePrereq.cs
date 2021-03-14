using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCStatePrereq : gameIScriptablePrereq
	{
		private CBool _previousState;
		private CBool _isInState;
		private CBool _skipWhenApplied;

		[Ordinal(0)] 
		[RED("previousState")] 
		public CBool PreviousState
		{
			get
			{
				if (_previousState == null)
				{
					_previousState = (CBool) CR2WTypeManager.Create("Bool", "previousState", cr2w, this);
				}
				return _previousState;
			}
			set
			{
				if (_previousState == value)
				{
					return;
				}
				_previousState = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInState")] 
		public CBool IsInState
		{
			get
			{
				if (_isInState == null)
				{
					_isInState = (CBool) CR2WTypeManager.Create("Bool", "isInState", cr2w, this);
				}
				return _isInState;
			}
			set
			{
				if (_isInState == value)
				{
					return;
				}
				_isInState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("skipWhenApplied")] 
		public CBool SkipWhenApplied
		{
			get
			{
				if (_skipWhenApplied == null)
				{
					_skipWhenApplied = (CBool) CR2WTypeManager.Create("Bool", "skipWhenApplied", cr2w, this);
				}
				return _skipWhenApplied;
			}
			set
			{
				if (_skipWhenApplied == value)
				{
					return;
				}
				_skipWhenApplied = value;
				PropertySet(this);
			}
		}

		public NPCStatePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
