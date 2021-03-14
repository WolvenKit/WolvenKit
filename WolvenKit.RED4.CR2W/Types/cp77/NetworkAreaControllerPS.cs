using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkAreaControllerPS : MasterControllerPS
	{
		private CBool _isActive;
		private CUInt32 _visualizerID;
		private CBool _hudActivated;
		private CInt32 _currentlyAvailableCharges;
		private CInt32 _maxAvailableCharges;

		[Ordinal(104)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("visualizerID")] 
		public CUInt32 VisualizerID
		{
			get
			{
				if (_visualizerID == null)
				{
					_visualizerID = (CUInt32) CR2WTypeManager.Create("Uint32", "visualizerID", cr2w, this);
				}
				return _visualizerID;
			}
			set
			{
				if (_visualizerID == value)
				{
					return;
				}
				_visualizerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("hudActivated")] 
		public CBool HudActivated
		{
			get
			{
				if (_hudActivated == null)
				{
					_hudActivated = (CBool) CR2WTypeManager.Create("Bool", "hudActivated", cr2w, this);
				}
				return _hudActivated;
			}
			set
			{
				if (_hudActivated == value)
				{
					return;
				}
				_hudActivated = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("currentlyAvailableCharges")] 
		public CInt32 CurrentlyAvailableCharges
		{
			get
			{
				if (_currentlyAvailableCharges == null)
				{
					_currentlyAvailableCharges = (CInt32) CR2WTypeManager.Create("Int32", "currentlyAvailableCharges", cr2w, this);
				}
				return _currentlyAvailableCharges;
			}
			set
			{
				if (_currentlyAvailableCharges == value)
				{
					return;
				}
				_currentlyAvailableCharges = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("maxAvailableCharges")] 
		public CInt32 MaxAvailableCharges
		{
			get
			{
				if (_maxAvailableCharges == null)
				{
					_maxAvailableCharges = (CInt32) CR2WTypeManager.Create("Int32", "maxAvailableCharges", cr2w, this);
				}
				return _maxAvailableCharges;
			}
			set
			{
				if (_maxAvailableCharges == value)
				{
					return;
				}
				_maxAvailableCharges = value;
				PropertySet(this);
			}
		}

		public NetworkAreaControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
