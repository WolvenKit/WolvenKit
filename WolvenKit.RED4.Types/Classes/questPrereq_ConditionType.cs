using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPrereq_ConditionType : questISystemConditionType
	{
		private gameEntityReference _objectRef;
		private CBool _isObjectPlayer;
		private CHandle<gameIPrereq> _prereq;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("isObjectPlayer")] 
		public CBool IsObjectPlayer
		{
			get => GetProperty(ref _isObjectPlayer);
			set => SetProperty(ref _isObjectPlayer, value);
		}

		[Ordinal(2)] 
		[RED("prereq")] 
		public CHandle<gameIPrereq> Prereq
		{
			get => GetProperty(ref _prereq);
			set => SetProperty(ref _prereq, value);
		}
	}
}
