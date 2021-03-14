using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLightChannelComponent : entIVisualComponent
	{
		private CBool _isEnabled;
		private CEnum<rendLightChannel> _channels;
		private CHandle<GeometryShape> _shape;

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
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

		[Ordinal(10)] 
		[RED("shape")] 
		public CHandle<GeometryShape> Shape
		{
			get
			{
				if (_shape == null)
				{
					_shape = (CHandle<GeometryShape>) CR2WTypeManager.Create("handle:GeometryShape", "shape", cr2w, this);
				}
				return _shape;
			}
			set
			{
				if (_shape == value)
				{
					return;
				}
				_shape = value;
				PropertySet(this);
			}
		}

		public entLightChannelComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
