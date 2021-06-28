using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameWeakSpotReplicatedInfo : CVariable
	{
		private CUInt64 _weakSpotRecordID;
		private CFloat _wsHealthValue;
		private wCHandle<gamePuppet> _lastDamageInstigator;

		[Ordinal(0)] 
		[RED("weakSpotRecordID")] 
		public CUInt64 WeakSpotRecordID
		{
			get => GetProperty(ref _weakSpotRecordID);
			set => SetProperty(ref _weakSpotRecordID, value);
		}

		[Ordinal(1)] 
		[RED("wsHealthValue")] 
		public CFloat WsHealthValue
		{
			get => GetProperty(ref _wsHealthValue);
			set => SetProperty(ref _wsHealthValue, value);
		}

		[Ordinal(2)] 
		[RED("LastDamageInstigator")] 
		public wCHandle<gamePuppet> LastDamageInstigator
		{
			get => GetProperty(ref _lastDamageInstigator);
			set => SetProperty(ref _lastDamageInstigator, value);
		}

		public gameWeakSpotReplicatedInfo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
