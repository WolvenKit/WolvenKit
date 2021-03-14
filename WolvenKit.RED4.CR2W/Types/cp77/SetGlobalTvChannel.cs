using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGlobalTvChannel : redEvent
	{
		private TweakDBID _channel;

		[Ordinal(0)] 
		[RED("channel")] 
		public TweakDBID Channel
		{
			get
			{
				if (_channel == null)
				{
					_channel = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "channel", cr2w, this);
				}
				return _channel;
			}
			set
			{
				if (_channel == value)
				{
					return;
				}
				_channel = value;
				PropertySet(this);
			}
		}

		public SetGlobalTvChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
