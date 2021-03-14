using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTransformAnimatorNode_Action_Play : questTransformAnimatorNode_ActionType
	{
		private CInt32 _timesPlayed;
		private CFloat _timeScale;
		private CBool _reverse;
		private CBool _useEntitySetup;

		[Ordinal(0)] 
		[RED("timesPlayed")] 
		public CInt32 TimesPlayed
		{
			get
			{
				if (_timesPlayed == null)
				{
					_timesPlayed = (CInt32) CR2WTypeManager.Create("Int32", "timesPlayed", cr2w, this);
				}
				return _timesPlayed;
			}
			set
			{
				if (_timesPlayed == value)
				{
					return;
				}
				_timesPlayed = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get
			{
				if (_timeScale == null)
				{
					_timeScale = (CFloat) CR2WTypeManager.Create("Float", "timeScale", cr2w, this);
				}
				return _timeScale;
			}
			set
			{
				if (_timeScale == value)
				{
					return;
				}
				_timeScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CBool) CR2WTypeManager.Create("Bool", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useEntitySetup")] 
		public CBool UseEntitySetup
		{
			get
			{
				if (_useEntitySetup == null)
				{
					_useEntitySetup = (CBool) CR2WTypeManager.Create("Bool", "useEntitySetup", cr2w, this);
				}
				return _useEntitySetup;
			}
			set
			{
				if (_useEntitySetup == value)
				{
					return;
				}
				_useEntitySetup = value;
				PropertySet(this);
			}
		}

		public questTransformAnimatorNode_Action_Play(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
