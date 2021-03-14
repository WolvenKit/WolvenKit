using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_WeightedQuat : ISerializable
	{
		private CHandle<animIAnimNodeSourceChannel_Quat> _channel;
		private CFloat _weight;
		private animFloatLink _weightLink;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(0)] 
		[RED("channel")] 
		public CHandle<animIAnimNodeSourceChannel_Quat> Channel
		{
			get
			{
				if (_channel == null)
				{
					_channel = (CHandle<animIAnimNodeSourceChannel_Quat>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_Quat", "channel", cr2w, this);
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

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weightLink")] 
		public animFloatLink WeightLink
		{
			get
			{
				if (_weightLink == null)
				{
					_weightLink = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightLink", cr2w, this);
				}
				return _weightLink;
			}
			set
			{
				if (_weightLink == value)
				{
					return;
				}
				_weightLink = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get
			{
				if (_weightFloatTrack == null)
				{
					_weightFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "weightFloatTrack", cr2w, this);
				}
				return _weightFloatTrack;
			}
			set
			{
				if (_weightFloatTrack == value)
				{
					return;
				}
				_weightFloatTrack = value;
				PropertySet(this);
			}
		}

		public animAnimNodeSourceChannel_WeightedQuat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
