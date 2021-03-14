using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkISystemRequestsHandler : IScriptable
	{
		private inkSystemRequesResult _savesReady;
		private inkSaveMetadataRequestResult _saveMetadataReady;
		private inkDeleteRequestResult _saveDeleted;
		private inkSystemServerRequesResult _serversSearchResult;
		private inkUserIdResult _userChanged;
		private inkUserIdResult _userIdResult;

		[Ordinal(0)] 
		[RED("SavesReady")] 
		public inkSystemRequesResult SavesReady
		{
			get
			{
				if (_savesReady == null)
				{
					_savesReady = (inkSystemRequesResult) CR2WTypeManager.Create("inkSystemRequesResult", "SavesReady", cr2w, this);
				}
				return _savesReady;
			}
			set
			{
				if (_savesReady == value)
				{
					return;
				}
				_savesReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("SaveMetadataReady")] 
		public inkSaveMetadataRequestResult SaveMetadataReady
		{
			get
			{
				if (_saveMetadataReady == null)
				{
					_saveMetadataReady = (inkSaveMetadataRequestResult) CR2WTypeManager.Create("inkSaveMetadataRequestResult", "SaveMetadataReady", cr2w, this);
				}
				return _saveMetadataReady;
			}
			set
			{
				if (_saveMetadataReady == value)
				{
					return;
				}
				_saveMetadataReady = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get
			{
				if (_saveDeleted == null)
				{
					_saveDeleted = (inkDeleteRequestResult) CR2WTypeManager.Create("inkDeleteRequestResult", "SaveDeleted", cr2w, this);
				}
				return _saveDeleted;
			}
			set
			{
				if (_saveDeleted == value)
				{
					return;
				}
				_saveDeleted = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get
			{
				if (_serversSearchResult == null)
				{
					_serversSearchResult = (inkSystemServerRequesResult) CR2WTypeManager.Create("inkSystemServerRequesResult", "ServersSearchResult", cr2w, this);
				}
				return _serversSearchResult;
			}
			set
			{
				if (_serversSearchResult == value)
				{
					return;
				}
				_serversSearchResult = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get
			{
				if (_userChanged == null)
				{
					_userChanged = (inkUserIdResult) CR2WTypeManager.Create("inkUserIdResult", "UserChanged", cr2w, this);
				}
				return _userChanged;
			}
			set
			{
				if (_userChanged == value)
				{
					return;
				}
				_userChanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get
			{
				if (_userIdResult == null)
				{
					_userIdResult = (inkUserIdResult) CR2WTypeManager.Create("inkUserIdResult", "UserIdResult", cr2w, this);
				}
				return _userIdResult;
			}
			set
			{
				if (_userIdResult == value)
				{
					return;
				}
				_userIdResult = value;
				PropertySet(this);
			}
		}

		public inkISystemRequestsHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
