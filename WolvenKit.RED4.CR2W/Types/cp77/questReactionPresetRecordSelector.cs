using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questReactionPresetRecordSelector : ISerializable
	{
		private CBool _setDefault;
		private CBool _isGanger;
		private TweakDBID _gangerRecordID;
		private CBool _isCivilian;
		private TweakDBID _civilianRecordID;
		private CBool _isCorpo;
		private TweakDBID _corpoRecordID;
		private CBool _isPolice;
		private TweakDBID _policeRecordID;
		private CBool _isMechanical;
		private TweakDBID _mechanicalRecordID;
		private CBool _isNoReaction;
		private TweakDBID _noReactionRecordID;

		[Ordinal(0)] 
		[RED("setDefault")] 
		public CBool SetDefault
		{
			get => GetProperty(ref _setDefault);
			set => SetProperty(ref _setDefault, value);
		}

		[Ordinal(1)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get => GetProperty(ref _isGanger);
			set => SetProperty(ref _isGanger, value);
		}

		[Ordinal(2)] 
		[RED("gangerRecordID")] 
		public TweakDBID GangerRecordID
		{
			get => GetProperty(ref _gangerRecordID);
			set => SetProperty(ref _gangerRecordID, value);
		}

		[Ordinal(3)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetProperty(ref _isCivilian);
			set => SetProperty(ref _isCivilian, value);
		}

		[Ordinal(4)] 
		[RED("civilianRecordID")] 
		public TweakDBID CivilianRecordID
		{
			get => GetProperty(ref _civilianRecordID);
			set => SetProperty(ref _civilianRecordID, value);
		}

		[Ordinal(5)] 
		[RED("isCorpo")] 
		public CBool IsCorpo
		{
			get => GetProperty(ref _isCorpo);
			set => SetProperty(ref _isCorpo, value);
		}

		[Ordinal(6)] 
		[RED("corpoRecordID")] 
		public TweakDBID CorpoRecordID
		{
			get => GetProperty(ref _corpoRecordID);
			set => SetProperty(ref _corpoRecordID, value);
		}

		[Ordinal(7)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get => GetProperty(ref _isPolice);
			set => SetProperty(ref _isPolice, value);
		}

		[Ordinal(8)] 
		[RED("policeRecordID")] 
		public TweakDBID PoliceRecordID
		{
			get => GetProperty(ref _policeRecordID);
			set => SetProperty(ref _policeRecordID, value);
		}

		[Ordinal(9)] 
		[RED("isMechanical")] 
		public CBool IsMechanical
		{
			get => GetProperty(ref _isMechanical);
			set => SetProperty(ref _isMechanical, value);
		}

		[Ordinal(10)] 
		[RED("mechanicalRecordID")] 
		public TweakDBID MechanicalRecordID
		{
			get => GetProperty(ref _mechanicalRecordID);
			set => SetProperty(ref _mechanicalRecordID, value);
		}

		[Ordinal(11)] 
		[RED("isNoReaction")] 
		public CBool IsNoReaction
		{
			get => GetProperty(ref _isNoReaction);
			set => SetProperty(ref _isNoReaction, value);
		}

		[Ordinal(12)] 
		[RED("noReactionRecordID")] 
		public TweakDBID NoReactionRecordID
		{
			get => GetProperty(ref _noReactionRecordID);
			set => SetProperty(ref _noReactionRecordID, value);
		}

		public questReactionPresetRecordSelector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
