using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBuffInfo : CVariable
	{
		private TweakDBID _buffID;
		private CFloat _timeRemaining;

		[Ordinal(0)] 
		[RED("buffID")] 
		public TweakDBID BuffID
		{
			get
			{
				if (_buffID == null)
				{
					_buffID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "buffID", cr2w, this);
				}
				return _buffID;
			}
			set
			{
				if (_buffID == value)
				{
					return;
				}
				_buffID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timeRemaining")] 
		public CFloat TimeRemaining
		{
			get
			{
				if (_timeRemaining == null)
				{
					_timeRemaining = (CFloat) CR2WTypeManager.Create("Float", "timeRemaining", cr2w, this);
				}
				return _timeRemaining;
			}
			set
			{
				if (_timeRemaining == value)
				{
					return;
				}
				_timeRemaining = value;
				PropertySet(this);
			}
		}

		public gameuiBuffInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
