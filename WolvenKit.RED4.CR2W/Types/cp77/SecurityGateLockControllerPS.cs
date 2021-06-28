using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityGateLockControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<TrespasserEntry> _tresspasserList;
		private entEntityID _entranceToken;
		private CBool _isLeaving;
		private CBool _isLocked;

		[Ordinal(103)] 
		[RED("tresspasserList")] 
		public CArray<TrespasserEntry> TresspasserList
		{
			get => GetProperty(ref _tresspasserList);
			set => SetProperty(ref _tresspasserList, value);
		}

		[Ordinal(104)] 
		[RED("entranceToken")] 
		public entEntityID EntranceToken
		{
			get => GetProperty(ref _entranceToken);
			set => SetProperty(ref _entranceToken, value);
		}

		[Ordinal(105)] 
		[RED("isLeaving")] 
		public CBool IsLeaving
		{
			get => GetProperty(ref _isLeaving);
			set => SetProperty(ref _isLeaving, value);
		}

		[Ordinal(106)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		public SecurityGateLockControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
