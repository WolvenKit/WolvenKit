using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayerSpawnParams : CVariable
	{
		private CBool _isSpectator;
		private Transform _spawnPoint;
		private TweakDBID _recordId;
		private CName _gender;
		private CBool _useSpecifiedStartPoint;
		private redTagList _spawnTags;
		private CString _nickname;

		[Ordinal(0)] 
		[RED("isSpectator")] 
		public CBool IsSpectator
		{
			get
			{
				if (_isSpectator == null)
				{
					_isSpectator = (CBool) CR2WTypeManager.Create("Bool", "isSpectator", cr2w, this);
				}
				return _isSpectator;
			}
			set
			{
				if (_isSpectator == value)
				{
					return;
				}
				_isSpectator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spawnPoint")] 
		public Transform SpawnPoint
		{
			get
			{
				if (_spawnPoint == null)
				{
					_spawnPoint = (Transform) CR2WTypeManager.Create("Transform", "spawnPoint", cr2w, this);
				}
				return _spawnPoint;
			}
			set
			{
				if (_spawnPoint == value)
				{
					return;
				}
				_spawnPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get
			{
				if (_recordId == null)
				{
					_recordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordId", cr2w, this);
				}
				return _recordId;
			}
			set
			{
				if (_recordId == value)
				{
					return;
				}
				_recordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("gender")] 
		public CName Gender
		{
			get
			{
				if (_gender == null)
				{
					_gender = (CName) CR2WTypeManager.Create("CName", "gender", cr2w, this);
				}
				return _gender;
			}
			set
			{
				if (_gender == value)
				{
					return;
				}
				_gender = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("useSpecifiedStartPoint")] 
		public CBool UseSpecifiedStartPoint
		{
			get
			{
				if (_useSpecifiedStartPoint == null)
				{
					_useSpecifiedStartPoint = (CBool) CR2WTypeManager.Create("Bool", "useSpecifiedStartPoint", cr2w, this);
				}
				return _useSpecifiedStartPoint;
			}
			set
			{
				if (_useSpecifiedStartPoint == value)
				{
					return;
				}
				_useSpecifiedStartPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("spawnTags")] 
		public redTagList SpawnTags
		{
			get
			{
				if (_spawnTags == null)
				{
					_spawnTags = (redTagList) CR2WTypeManager.Create("redTagList", "spawnTags", cr2w, this);
				}
				return _spawnTags;
			}
			set
			{
				if (_spawnTags == value)
				{
					return;
				}
				_spawnTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get
			{
				if (_nickname == null)
				{
					_nickname = (CString) CR2WTypeManager.Create("String", "nickname", cr2w, this);
				}
				return _nickname;
			}
			set
			{
				if (_nickname == value)
				{
					return;
				}
				_nickname = value;
				PropertySet(this);
			}
		}

		public gamePlayerSpawnParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
