using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CInt32 _previousStation;
		private CString _activeChannelName;
		private CBool _dataInitialized;
		private CInt32 _amountOfStations;
		private CInt32 _activeStation;

		[Ordinal(103)] 
		[RED("previousStation")] 
		public CInt32 PreviousStation
		{
			get
			{
				if (_previousStation == null)
				{
					_previousStation = (CInt32) CR2WTypeManager.Create("Int32", "previousStation", cr2w, this);
				}
				return _previousStation;
			}
			set
			{
				if (_previousStation == value)
				{
					return;
				}
				_previousStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("activeChannelName")] 
		public CString ActiveChannelName
		{
			get
			{
				if (_activeChannelName == null)
				{
					_activeChannelName = (CString) CR2WTypeManager.Create("String", "activeChannelName", cr2w, this);
				}
				return _activeChannelName;
			}
			set
			{
				if (_activeChannelName == value)
				{
					return;
				}
				_activeChannelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("dataInitialized")] 
		public CBool DataInitialized
		{
			get
			{
				if (_dataInitialized == null)
				{
					_dataInitialized = (CBool) CR2WTypeManager.Create("Bool", "dataInitialized", cr2w, this);
				}
				return _dataInitialized;
			}
			set
			{
				if (_dataInitialized == value)
				{
					return;
				}
				_dataInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("amountOfStations")] 
		public CInt32 AmountOfStations
		{
			get
			{
				if (_amountOfStations == null)
				{
					_amountOfStations = (CInt32) CR2WTypeManager.Create("Int32", "amountOfStations", cr2w, this);
				}
				return _amountOfStations;
			}
			set
			{
				if (_amountOfStations == value)
				{
					return;
				}
				_amountOfStations = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("activeStation")] 
		public CInt32 ActiveStation
		{
			get
			{
				if (_activeStation == null)
				{
					_activeStation = (CInt32) CR2WTypeManager.Create("Int32", "activeStation", cr2w, this);
				}
				return _activeStation;
			}
			set
			{
				if (_activeStation == value)
				{
					return;
				}
				_activeStation = value;
				PropertySet(this);
			}
		}

		public MediaDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
