using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class EntityNoticedPlayerPrereq : gameIScriptablePrereq
	{
		private CBool _isPlayerNoticed;
		private CUInt32 _valueToListen;

		[Ordinal(0)] 
		[RED("isPlayerNoticed")] 
		public CBool IsPlayerNoticed
		{
			get => GetProperty(ref _isPlayerNoticed);
			set => SetProperty(ref _isPlayerNoticed, value);
		}

		[Ordinal(1)] 
		[RED("valueToListen")] 
		public CUInt32 ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}

		public EntityNoticedPlayerPrereq()
		{
			_valueToListen = 1;
		}
	}
}
