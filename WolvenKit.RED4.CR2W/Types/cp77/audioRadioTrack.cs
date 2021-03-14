using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioRadioTrack : CVariable
	{
		private CName _trackEventName;
		private CName _localizationKey;
		private CUInt64 _primaryLocKey;
		private CBool _isStreamingFriendly;

		[Ordinal(0)] 
		[RED("trackEventName")] 
		public CName TrackEventName
		{
			get
			{
				if (_trackEventName == null)
				{
					_trackEventName = (CName) CR2WTypeManager.Create("CName", "trackEventName", cr2w, this);
				}
				return _trackEventName;
			}
			set
			{
				if (_trackEventName == value)
				{
					return;
				}
				_trackEventName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localizationKey")] 
		public CName LocalizationKey
		{
			get
			{
				if (_localizationKey == null)
				{
					_localizationKey = (CName) CR2WTypeManager.Create("CName", "localizationKey", cr2w, this);
				}
				return _localizationKey;
			}
			set
			{
				if (_localizationKey == value)
				{
					return;
				}
				_localizationKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("primaryLocKey")] 
		public CUInt64 PrimaryLocKey
		{
			get
			{
				if (_primaryLocKey == null)
				{
					_primaryLocKey = (CUInt64) CR2WTypeManager.Create("Uint64", "primaryLocKey", cr2w, this);
				}
				return _primaryLocKey;
			}
			set
			{
				if (_primaryLocKey == value)
				{
					return;
				}
				_primaryLocKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isStreamingFriendly")] 
		public CBool IsStreamingFriendly
		{
			get
			{
				if (_isStreamingFriendly == null)
				{
					_isStreamingFriendly = (CBool) CR2WTypeManager.Create("Bool", "isStreamingFriendly", cr2w, this);
				}
				return _isStreamingFriendly;
			}
			set
			{
				if (_isStreamingFriendly == value)
				{
					return;
				}
				_isStreamingFriendly = value;
				PropertySet(this);
			}
		}

		public audioRadioTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
