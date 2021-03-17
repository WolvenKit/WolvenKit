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
			get => GetProperty(ref _isSpectator);
			set => SetProperty(ref _isSpectator, value);
		}

		[Ordinal(1)] 
		[RED("spawnPoint")] 
		public Transform SpawnPoint
		{
			get => GetProperty(ref _spawnPoint);
			set => SetProperty(ref _spawnPoint, value);
		}

		[Ordinal(2)] 
		[RED("recordId")] 
		public TweakDBID RecordId
		{
			get => GetProperty(ref _recordId);
			set => SetProperty(ref _recordId, value);
		}

		[Ordinal(3)] 
		[RED("gender")] 
		public CName Gender
		{
			get => GetProperty(ref _gender);
			set => SetProperty(ref _gender, value);
		}

		[Ordinal(4)] 
		[RED("useSpecifiedStartPoint")] 
		public CBool UseSpecifiedStartPoint
		{
			get => GetProperty(ref _useSpecifiedStartPoint);
			set => SetProperty(ref _useSpecifiedStartPoint, value);
		}

		[Ordinal(5)] 
		[RED("spawnTags")] 
		public redTagList SpawnTags
		{
			get => GetProperty(ref _spawnTags);
			set => SetProperty(ref _spawnTags, value);
		}

		[Ordinal(6)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get => GetProperty(ref _nickname);
			set => SetProperty(ref _nickname, value);
		}

		public gamePlayerSpawnParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
