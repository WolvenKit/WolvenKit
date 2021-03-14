using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaDeviceData : CVariable
	{
		private CInt32 _initialStation;
		private CInt32 _amountOfStations;
		private CString _activeChannelName;
		private CBool _isInteractive;

		[Ordinal(0)] 
		[RED("initialStation")] 
		public CInt32 InitialStation
		{
			get
			{
				if (_initialStation == null)
				{
					_initialStation = (CInt32) CR2WTypeManager.Create("Int32", "initialStation", cr2w, this);
				}
				return _initialStation;
			}
			set
			{
				if (_initialStation == value)
				{
					return;
				}
				_initialStation = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		public MediaDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
