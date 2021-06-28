using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMultiplayerGiveChoiceTokenEvent : redEvent
	{
		private CName _compatibleDeviceName;
		private CUInt32 _timeout;
		private CBool _tokenAlreadyGiven;

		[Ordinal(0)] 
		[RED("compatibleDeviceName")] 
		public CName CompatibleDeviceName
		{
			get => GetProperty(ref _compatibleDeviceName);
			set => SetProperty(ref _compatibleDeviceName, value);
		}

		[Ordinal(1)] 
		[RED("timeout")] 
		public CUInt32 Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		[Ordinal(2)] 
		[RED("tokenAlreadyGiven")] 
		public CBool TokenAlreadyGiven
		{
			get => GetProperty(ref _tokenAlreadyGiven);
			set => SetProperty(ref _tokenAlreadyGiven, value);
		}

		public questMultiplayerGiveChoiceTokenEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
