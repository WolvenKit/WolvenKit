using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FastTravelButtonLogicController : inkButtonController
	{
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _locationName;
		private SSoundData _soundData;
		private CBool _isInitialized;
		private wCHandle<gameFastTravelPointData> _fastTravelPointData;

		[Ordinal(10)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get
			{
				if (_districtName == null)
				{
					_districtName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "districtName", cr2w, this);
				}
				return _districtName;
			}
			set
			{
				if (_districtName == value)
				{
					return;
				}
				_districtName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("locationName")] 
		public inkTextWidgetReference LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("soundData")] 
		public SSoundData SoundData
		{
			get
			{
				if (_soundData == null)
				{
					_soundData = (SSoundData) CR2WTypeManager.Create("SSoundData", "soundData", cr2w, this);
				}
				return _soundData;
			}
			set
			{
				if (_soundData == value)
				{
					return;
				}
				_soundData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isInitialized")] 
		public CBool IsInitialized
		{
			get
			{
				if (_isInitialized == null)
				{
					_isInitialized = (CBool) CR2WTypeManager.Create("Bool", "isInitialized", cr2w, this);
				}
				return _isInitialized;
			}
			set
			{
				if (_isInitialized == value)
				{
					return;
				}
				_isInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("fastTravelPointData")] 
		public wCHandle<gameFastTravelPointData> FastTravelPointData
		{
			get
			{
				if (_fastTravelPointData == null)
				{
					_fastTravelPointData = (wCHandle<gameFastTravelPointData>) CR2WTypeManager.Create("whandle:gameFastTravelPointData", "fastTravelPointData", cr2w, this);
				}
				return _fastTravelPointData;
			}
			set
			{
				if (_fastTravelPointData == value)
				{
					return;
				}
				_fastTravelPointData = value;
				PropertySet(this);
			}
		}

		public FastTravelButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
