using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CPOMissionDataState : IScriptable
	{
		private CName _cPOMissionDataDamagesPreset;
		private CName _compatibleDeviceName;
		private CBool _ownerDecidesOnTransfer;
		private CBool _isChoiceToken;
		private CUInt32 _choiceTokenTimeout;
		private gameDelayID _delayedGiveChoiceTokenEventId;
		private CUInt32 _dataDamageTextLayerId;

		[Ordinal(0)] 
		[RED("CPOMissionDataDamagesPreset")] 
		public CName CPOMissionDataDamagesPreset
		{
			get => GetProperty(ref _cPOMissionDataDamagesPreset);
			set => SetProperty(ref _cPOMissionDataDamagesPreset, value);
		}

		[Ordinal(1)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetProperty(ref _compatibleDeviceName);
			set => SetProperty(ref _compatibleDeviceName, value);
		}

		[Ordinal(2)] 
		[RED("ownerDecidesOnTransfer")] 
		public CBool OwnerDecidesOnTransfer
		{
			get => GetProperty(ref _ownerDecidesOnTransfer);
			set => SetProperty(ref _ownerDecidesOnTransfer, value);
		}

		[Ordinal(3)] 
		[RED("isChoiceToken")] 
		public CBool IsChoiceToken
		{
			get => GetProperty(ref _isChoiceToken);
			set => SetProperty(ref _isChoiceToken, value);
		}

		[Ordinal(4)] 
		[RED("choiceTokenTimeout")] 
		public CUInt32 ChoiceTokenTimeout
		{
			get => GetProperty(ref _choiceTokenTimeout);
			set => SetProperty(ref _choiceTokenTimeout, value);
		}

		[Ordinal(5)] 
		[RED("delayedGiveChoiceTokenEventId")] 
		public gameDelayID DelayedGiveChoiceTokenEventId
		{
			get => GetProperty(ref _delayedGiveChoiceTokenEventId);
			set => SetProperty(ref _delayedGiveChoiceTokenEventId, value);
		}

		[Ordinal(6)] 
		[RED("dataDamageTextLayerId")] 
		public CUInt32 DataDamageTextLayerId
		{
			get => GetProperty(ref _dataDamageTextLayerId);
			set => SetProperty(ref _dataDamageTextLayerId, value);
		}

		public CPOMissionDataState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
