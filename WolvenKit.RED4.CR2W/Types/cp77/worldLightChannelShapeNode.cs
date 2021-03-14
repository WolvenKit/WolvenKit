using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldLightChannelShapeNode : worldGeometryShapeNode
	{
		private CEnum<rendLightChannel> _channels;
		private CFloat _streamingDistanceFactor;

		[Ordinal(6)] 
		[RED("channels")] 
		public CEnum<rendLightChannel> Channels
		{
			get
			{
				if (_channels == null)
				{
					_channels = (CEnum<rendLightChannel>) CR2WTypeManager.Create("rendLightChannel", "channels", cr2w, this);
				}
				return _channels;
			}
			set
			{
				if (_channels == value)
				{
					return;
				}
				_channels = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("streamingDistanceFactor")] 
		public CFloat StreamingDistanceFactor
		{
			get
			{
				if (_streamingDistanceFactor == null)
				{
					_streamingDistanceFactor = (CFloat) CR2WTypeManager.Create("Float", "streamingDistanceFactor", cr2w, this);
				}
				return _streamingDistanceFactor;
			}
			set
			{
				if (_streamingDistanceFactor == value)
				{
					return;
				}
				_streamingDistanceFactor = value;
				PropertySet(this);
			}
		}

		public worldLightChannelShapeNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
