using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTransformOutput : CVariable
	{
		private animTransformIndex _targetTransform;
		private animTransformIndex _parentTransform;
		private CEnum<animTransformChannel> _targetTransformChannel;
		private CFloat _multiplier;
		private CArray<animSimpleBounceTransformOutput_ChannelEntry> _channelEntries;

		[Ordinal(0)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get
			{
				if (_targetTransform == null)
				{
					_targetTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "targetTransform", cr2w, this);
				}
				return _targetTransform;
			}
			set
			{
				if (_targetTransform == value)
				{
					return;
				}
				_targetTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("parentTransform")] 
		public animTransformIndex ParentTransform
		{
			get
			{
				if (_parentTransform == null)
				{
					_parentTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "parentTransform", cr2w, this);
				}
				return _parentTransform;
			}
			set
			{
				if (_parentTransform == value)
				{
					return;
				}
				_parentTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("targetTransformChannel")] 
		public CEnum<animTransformChannel> TargetTransformChannel
		{
			get
			{
				if (_targetTransformChannel == null)
				{
					_targetTransformChannel = (CEnum<animTransformChannel>) CR2WTypeManager.Create("animTransformChannel", "targetTransformChannel", cr2w, this);
				}
				return _targetTransformChannel;
			}
			set
			{
				if (_targetTransformChannel == value)
				{
					return;
				}
				_targetTransformChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("channelEntries")] 
		public CArray<animSimpleBounceTransformOutput_ChannelEntry> ChannelEntries
		{
			get
			{
				if (_channelEntries == null)
				{
					_channelEntries = (CArray<animSimpleBounceTransformOutput_ChannelEntry>) CR2WTypeManager.Create("array:animSimpleBounceTransformOutput_ChannelEntry", "channelEntries", cr2w, this);
				}
				return _channelEntries;
			}
			set
			{
				if (_channelEntries == value)
				{
					return;
				}
				_channelEntries = value;
				PropertySet(this);
			}
		}

		public animSimpleBounceTransformOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
