using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SChannelEnumData : CVariable
	{
		private CEnum<ETVChannel> _channel;

		[Ordinal(0)] 
		[RED("channel")] 
		public CEnum<ETVChannel> Channel
		{
			get
			{
				if (_channel == null)
				{
					_channel = (CEnum<ETVChannel>) CR2WTypeManager.Create("ETVChannel", "channel", cr2w, this);
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

		public SChannelEnumData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
