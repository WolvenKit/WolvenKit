using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerQuickhackData : CVariable
	{
		private TweakDBID _actionTweak;
		private CFloat _actionPenetration;
		private CInt32 _quality;

		[Ordinal(0)] 
		[RED("actionTweak")] 
		public TweakDBID ActionTweak
		{
			get
			{
				if (_actionTweak == null)
				{
					_actionTweak = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "actionTweak", cr2w, this);
				}
				return _actionTweak;
			}
			set
			{
				if (_actionTweak == value)
				{
					return;
				}
				_actionTweak = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("actionPenetration")] 
		public CFloat ActionPenetration
		{
			get
			{
				if (_actionPenetration == null)
				{
					_actionPenetration = (CFloat) CR2WTypeManager.Create("Float", "actionPenetration", cr2w, this);
				}
				return _actionPenetration;
			}
			set
			{
				if (_actionPenetration == value)
				{
					return;
				}
				_actionPenetration = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("quality")] 
		public CInt32 Quality
		{
			get
			{
				if (_quality == null)
				{
					_quality = (CInt32) CR2WTypeManager.Create("Int32", "quality", cr2w, this);
				}
				return _quality;
			}
			set
			{
				if (_quality == value)
				{
					return;
				}
				_quality = value;
				PropertySet(this);
			}
		}

		public PlayerQuickhackData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
