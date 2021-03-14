using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput_ChannelEntry : CVariable
	{
		private CEnum<animTransformChannel> _transformChannel;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("transformChannel")] 
		public CEnum<animTransformChannel> TransformChannel
		{
			get
			{
				if (_transformChannel == null)
				{
					_transformChannel = (CEnum<animTransformChannel>) CR2WTypeManager.Create("animTransformChannel", "transformChannel", cr2w, this);
				}
				return _transformChannel;
			}
			set
			{
				if (_transformChannel == value)
				{
					return;
				}
				_transformChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get
			{
				if (_multiplier == null)
				{
					_multiplier = (CFloat) CR2WTypeManager.Create("Float", "multiplier", cr2w, this);
				}
				return _multiplier;
			}
			set
			{
				if (_multiplier == value)
				{
					return;
				}
				_multiplier = value;
				PropertySet(this);
			}
		}

		public animSimpleBounceTransformOutput_ChannelEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
