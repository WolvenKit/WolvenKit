using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVControllerPS : MediaDeviceControllerPS
	{
		private TVSetup _tvSetup;
		private redResourceReferenceScriptToken _defaultGlitchVideoPath;
		private redResourceReferenceScriptToken _broadcastGlitchVideoPath;
		private CBool _globalTVInitialized;
		private CArray<STvChannel> _backupCustomChannels;

		[Ordinal(108)] 
		[RED("tvSetup")] 
		public TVSetup TvSetup
		{
			get
			{
				if (_tvSetup == null)
				{
					_tvSetup = (TVSetup) CR2WTypeManager.Create("TVSetup", "tvSetup", cr2w, this);
				}
				return _tvSetup;
			}
			set
			{
				if (_tvSetup == value)
				{
					return;
				}
				_tvSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("defaultGlitchVideoPath")] 
		public redResourceReferenceScriptToken DefaultGlitchVideoPath
		{
			get
			{
				if (_defaultGlitchVideoPath == null)
				{
					_defaultGlitchVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "defaultGlitchVideoPath", cr2w, this);
				}
				return _defaultGlitchVideoPath;
			}
			set
			{
				if (_defaultGlitchVideoPath == value)
				{
					return;
				}
				_defaultGlitchVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("broadcastGlitchVideoPath")] 
		public redResourceReferenceScriptToken BroadcastGlitchVideoPath
		{
			get
			{
				if (_broadcastGlitchVideoPath == null)
				{
					_broadcastGlitchVideoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "broadcastGlitchVideoPath", cr2w, this);
				}
				return _broadcastGlitchVideoPath;
			}
			set
			{
				if (_broadcastGlitchVideoPath == value)
				{
					return;
				}
				_broadcastGlitchVideoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("globalTVInitialized")] 
		public CBool GlobalTVInitialized
		{
			get
			{
				if (_globalTVInitialized == null)
				{
					_globalTVInitialized = (CBool) CR2WTypeManager.Create("Bool", "globalTVInitialized", cr2w, this);
				}
				return _globalTVInitialized;
			}
			set
			{
				if (_globalTVInitialized == value)
				{
					return;
				}
				_globalTVInitialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("backupCustomChannels")] 
		public CArray<STvChannel> BackupCustomChannels
		{
			get
			{
				if (_backupCustomChannels == null)
				{
					_backupCustomChannels = (CArray<STvChannel>) CR2WTypeManager.Create("array:STvChannel", "backupCustomChannels", cr2w, this);
				}
				return _backupCustomChannels;
			}
			set
			{
				if (_backupCustomChannels == value)
				{
					return;
				}
				_backupCustomChannels = value;
				PropertySet(this);
			}
		}

		public TVControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
