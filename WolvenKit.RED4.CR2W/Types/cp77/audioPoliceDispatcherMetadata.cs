using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPoliceDispatcherMetadata : audioAudioMetadata
	{
		private CArray<CName> _regularInputs;
		private CArray<CName> _playerChaseStartInputs;
		private CArray<CName> _playerChaseBackupNeededInputs;
		private CArray<CName> _playerChaseEndInputs;
		private CFloat _dispatcherTimeInterval;
		private CString _sceneFilePath;

		[Ordinal(1)] 
		[RED("regularInputs")] 
		public CArray<CName> RegularInputs
		{
			get
			{
				if (_regularInputs == null)
				{
					_regularInputs = (CArray<CName>) CR2WTypeManager.Create("array:CName", "regularInputs", cr2w, this);
				}
				return _regularInputs;
			}
			set
			{
				if (_regularInputs == value)
				{
					return;
				}
				_regularInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerChaseStartInputs")] 
		public CArray<CName> PlayerChaseStartInputs
		{
			get
			{
				if (_playerChaseStartInputs == null)
				{
					_playerChaseStartInputs = (CArray<CName>) CR2WTypeManager.Create("array:CName", "playerChaseStartInputs", cr2w, this);
				}
				return _playerChaseStartInputs;
			}
			set
			{
				if (_playerChaseStartInputs == value)
				{
					return;
				}
				_playerChaseStartInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("playerChaseBackupNeededInputs")] 
		public CArray<CName> PlayerChaseBackupNeededInputs
		{
			get
			{
				if (_playerChaseBackupNeededInputs == null)
				{
					_playerChaseBackupNeededInputs = (CArray<CName>) CR2WTypeManager.Create("array:CName", "playerChaseBackupNeededInputs", cr2w, this);
				}
				return _playerChaseBackupNeededInputs;
			}
			set
			{
				if (_playerChaseBackupNeededInputs == value)
				{
					return;
				}
				_playerChaseBackupNeededInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerChaseEndInputs")] 
		public CArray<CName> PlayerChaseEndInputs
		{
			get
			{
				if (_playerChaseEndInputs == null)
				{
					_playerChaseEndInputs = (CArray<CName>) CR2WTypeManager.Create("array:CName", "playerChaseEndInputs", cr2w, this);
				}
				return _playerChaseEndInputs;
			}
			set
			{
				if (_playerChaseEndInputs == value)
				{
					return;
				}
				_playerChaseEndInputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dispatcherTimeInterval")] 
		public CFloat DispatcherTimeInterval
		{
			get
			{
				if (_dispatcherTimeInterval == null)
				{
					_dispatcherTimeInterval = (CFloat) CR2WTypeManager.Create("Float", "dispatcherTimeInterval", cr2w, this);
				}
				return _dispatcherTimeInterval;
			}
			set
			{
				if (_dispatcherTimeInterval == value)
				{
					return;
				}
				_dispatcherTimeInterval = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("sceneFilePath")] 
		public CString SceneFilePath
		{
			get
			{
				if (_sceneFilePath == null)
				{
					_sceneFilePath = (CString) CR2WTypeManager.Create("String", "sceneFilePath", cr2w, this);
				}
				return _sceneFilePath;
			}
			set
			{
				if (_sceneFilePath == value)
				{
					return;
				}
				_sceneFilePath = value;
				PropertySet(this);
			}
		}

		public audioPoliceDispatcherMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
