using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoadBlockControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isBlocking;
		private CBool _negateAnimState;
		private TweakDBID _nameForBlocking;
		private TweakDBID _nameForUnblocking;

		[Ordinal(103)] 
		[RED("isBlocking")] 
		public CBool IsBlocking
		{
			get
			{
				if (_isBlocking == null)
				{
					_isBlocking = (CBool) CR2WTypeManager.Create("Bool", "isBlocking", cr2w, this);
				}
				return _isBlocking;
			}
			set
			{
				if (_isBlocking == value)
				{
					return;
				}
				_isBlocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("negateAnimState")] 
		public CBool NegateAnimState
		{
			get
			{
				if (_negateAnimState == null)
				{
					_negateAnimState = (CBool) CR2WTypeManager.Create("Bool", "negateAnimState", cr2w, this);
				}
				return _negateAnimState;
			}
			set
			{
				if (_negateAnimState == value)
				{
					return;
				}
				_negateAnimState = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("nameForBlocking")] 
		public TweakDBID NameForBlocking
		{
			get
			{
				if (_nameForBlocking == null)
				{
					_nameForBlocking = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForBlocking", cr2w, this);
				}
				return _nameForBlocking;
			}
			set
			{
				if (_nameForBlocking == value)
				{
					return;
				}
				_nameForBlocking = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("nameForUnblocking")] 
		public TweakDBID NameForUnblocking
		{
			get
			{
				if (_nameForUnblocking == null)
				{
					_nameForUnblocking = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "nameForUnblocking", cr2w, this);
				}
				return _nameForUnblocking;
			}
			set
			{
				if (_nameForUnblocking == value)
				{
					return;
				}
				_nameForUnblocking = value;
				PropertySet(this);
			}
		}

		public RoadBlockControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
