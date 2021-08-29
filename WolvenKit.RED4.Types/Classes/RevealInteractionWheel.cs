using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RevealInteractionWheel : redEvent
	{
		private CWeakHandle<gameObject> _lookAtObject;
		private CArray<CHandle<QuickhackData>> _commands;
		private CBool _shouldReveal;

		[Ordinal(0)] 
		[RED("lookAtObject")] 
		public CWeakHandle<gameObject> LookAtObject
		{
			get => GetProperty(ref _lookAtObject);
			set => SetProperty(ref _lookAtObject, value);
		}

		[Ordinal(1)] 
		[RED("commands")] 
		public CArray<CHandle<QuickhackData>> Commands
		{
			get => GetProperty(ref _commands);
			set => SetProperty(ref _commands, value);
		}

		[Ordinal(2)] 
		[RED("shouldReveal")] 
		public CBool ShouldReveal
		{
			get => GetProperty(ref _shouldReveal);
			set => SetProperty(ref _shouldReveal, value);
		}
	}
}
